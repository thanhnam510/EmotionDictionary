﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmoDic
{
    public partial class frmXtract : Form
    {
        List<string> Terms = new List<string>();
        private List<int> G = new List<int>(); 
        private List<int> N; 
        private List<int> P; 
        public frmXtract()
        {
            InitializeComponent();
        }

        private void Xtract_Load(object sender, EventArgs e)
        {

        }

        private void createVector(List<int> TermValue)
        {
            G = TermValue;
            N = new List<int>();
            P = new List<int>();
            foreach (int value in G)
            {
                if (value == 0)
                {
                    N.Add(value);
                    P.Add(value);
                    continue;
                }
                if (value > 0)
                {
                    N.Add(0);
                    P.Add(value);
                }
                else
                {
                    N.Add(value);
                    P.Add(0);
                }
            }
        }
        private void cal()
        {
            double cosinNG = Math.Round(cosin(N),3);
            double cosinPG = Math.Round(cosin(P),3);
            double  kq = cosinPG - cosinNG;
            if(kq == 0)
            {
                lbrs2.Text = "Ý kiến trung lập";
            }
            else
            {
                if(kq > 0)
                {
                    lbrs2.Text = "Ý kiến tích cực";
                }
                else
                {
                    lbrs2.Text = "Ý kiến tiêu cực";
                }
            }
            

            lbrs.Text += "\ncosin(N,G)=" + cosinNG + "\nconsin(P,G)=" + cosinPG;
        }

        private double cosin(List<int> X) 
        {
            double sumPowX = 0; //numeratorX
            double sumPowG = 0;
            double denominator = 0;
            for(int i =0;i<G.Count;i++)
            {
                sumPowX += (int)Math.Pow(X[i], 2);
                sumPowG += (int)Math.Pow(G[i], 2);
            }
            denominator = Math.Sqrt(sumPowX) * Math.Sqrt(sumPowG);
            return (sumPowX / denominator);
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            lbrs.Text = "";
            string[] separators = { ".", "!", "?" };
            string[] sentences = txtA.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] words;
            string[] pharses;
            List<string> Terms = new List<string>();
            List<int> TermValues = new List<int>();
            foreach (String sentence in sentences)
            {
                string[] separators2 = { ",", ";" };
                pharses = sentence.Split(separators2, StringSplitOptions.RemoveEmptyEntries);
                foreach (string pharse in pharses)
                {
                    words = pharse.Split(' ');
                    int start = 0;
                    int stop = words.Length;
                    bool isStop = false;
                    string Term = "";
                    List<string> temp = new List<string>();
                    if (Program.KetNoi() == 0) return;
                    while (isStop == false && stop >= 0)
                    {
                        SqlDataReader myReader;
                        Term = "";
                        for (int i = start; i < stop; i++)
                        {
                            Term += words[i] + " ";
                        }
                        string strLenh = "exec dbo.SP_TimKiem N'"+ Term.Trim() + "'";
                        myReader = Program.ExecSqlDataReader(strLenh);
                        myReader.Read();
                        int  ret= myReader.GetInt32(0);
                        myReader.Close();
                        if (ret !=0 )
                        {
                            if (ret == 1)
                            {
                                temp.Add(Term.Trim());
                                Terms.Add(Term.Trim());
                            }
                            else
                            {
                                foreach(string t in temp)
                                {
                                    strLenh = "exec dbo.SP_LayTrongSo N'" + Term + "',N'" + t + "'";
                                    myReader = Program.ExecSqlDataReader(strLenh);
                                    myReader.Read();
                                    TermValues.Add(myReader.GetInt32(0));
                                    myReader.Close();
                                }
                                Terms.Add(Term.Trim());
                                TermValues.Add(-1);
                                temp = new List<string>();
                            }
                            if (start == 0)
                                isStop = true;
                            else
                            {
                                stop = start;
                                start = 0;
                            }
                        }
                        else
                        {
                            if (start == stop)
                            {
                                stop--;
                                start = 0;
                            }
                            else
                                start++;
                        }
                        
                    }

                }
            }
            for (int index = 0; index < Terms.Count; index++)
            {
                lbrs.Text += Terms[index]+": "+TermValues[index]+" | ";
            }
            createVector(TermValues);
            cal();
        }

    }
}
