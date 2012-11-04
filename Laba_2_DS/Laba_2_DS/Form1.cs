using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Laba_2_DS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int[][] Matrix = new int[0][];
        bool inpfromfile;

        private void stdmatr(ref int[][] a)
        {
            int[][] b = new int[7][];
            a[0] = new int[7] { 0, 1, 0, 0, 0, 0, 0 };
            a[1] = new int[7] { 0, 0, 1, 0, 0, 0, 0 };
            a[2] = new int[7] { 1, 0, 0, 0, 1, 0, 0 };
            a[3] = new int[7] { 0, 0, 1, 1, 0, 0, 0 };
            a[4] = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            a[5] = new int[7] { 0, 0, 0, 0, 1, 0, 1 };
            a[6] = new int[7] { 0, 0, 0, 0, 0, 0, 1 }; 
        }

        static void Output_Matrix(int[][] Mas, DataGridView dtgrdvw)
        {
            int col = Mas[0].Length;
            dtgrdvw.ColumnCount = 0;
            dtgrdvw.ColumnCount = col;
            dtgrdvw.Rows.Add(Mas.Length);
            for (int i = 0; i < col; i++)
            {
                dtgrdvw.Columns[i].ReadOnly = true;
                dtgrdvw.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dtgrdvw.Columns[i].Name = ("x"+(i+1)).ToString();
                dtgrdvw.Columns[i].Width = 25;
            }
            for (int i = 0; i < Mas.Length; i++)
                for (int j = 0; j < Mas[i].Length; j++)
                    dtgrdvw.Rows[i].Cells[j].Value = Mas[i][j].ToString();
        }

        private void Tplus(ref int[] vec, int stind, int k)
        {           
            int i = stind;
            for (int l = stind, j = 0; j < Matrix[l].Length; j++)                
                        if (Matrix[l][j] == 1)
                        {
                            if ((vec[j] != 10 && j != i))
                            {
                                stind = j;
                                vec[stind] = k;
                                Tplus(ref vec, stind, ++k);
                            }
                        }
        }

        private void Tminus(ref int[] vec, int stind, int k)
        {
            int i = stind;
            for (int l = stind, j = 0; j < Matrix.Length; j++)
                if (Matrix[j][l] == 1)
                {
                    if ((vec[j] != 10 && j != i))
                    {
                        stind = j;
                        vec[stind] = k;
                        Tminus(ref vec, stind, ++k);
                    }
                }
        }

        private void newstartindex(int[] g,ref int i)
        {
            try
            {
                {
                    for (int p = 0; p < g.Length - 1; p++)
                        if ((g[p] != 0 && g[p + 1] == 0))
                        {
                            i = p + 1;
                            //throw new Exception("Новый начальный элемент = " + (i + 1));
                            throw new Exception();
                        }
                        else i = g.Length;
                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            catch (Exception)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {                
            Array.Resize(ref Matrix, 7);
            stdmatr(ref Matrix);
            int i = 2;
            int count = 1;
            Output_Matrix(Matrix, dataGridView1);
            int[] Tp = {0,0,0,0,0,0,0};
            int[] Tm = new int[Matrix.Length];
            int[] G = new int[Matrix.Length];
            while (i < Matrix.Length) 
            {
                Tp[i] = 10;
                Tm[i] = 10;
                Tplus(ref Tp, i, 1);
                Tminus(ref Tm, i, 1);
                for (int k = 0; k < Tp.Length; k++)
                    if (Tp[k] != 0 && Tm[k] != 0)
                        G[k] = k + 1;
                TBTplus.Text += "Tplus" + count + "={  ";
                for (int k = 0; k < Tp.Length; k++)
                    if (Tp[k] != 0)
                        TBTplus.Text += "x" + Convert.ToString(k + 1) + "; ";
                TBTplus.Text += "}" + Environment.NewLine;
                TBTminus.Text += "Tminus" + count + "={  ";
                for (int k = 0; k < Tm.Length; k++)
                    if (Tm[k] != 0)
                        TBTminus.Text += "x" + Convert.ToString(k + 1) + "; ";
                TBTminus.Text += "}" + Environment.NewLine;
                TBG.Text += "G" + count + "={  ";
                for (int k = 0; k < G.Length; k++)
                    if (G[k] != 0)
                        TBG.Text += "x" + Convert.ToString(G[k]) + "; ";
                TBG.Text += "}" + Environment.NewLine;
                count++;
                int delel;
                for (int k = 0; k < G.Length; k++)
                    if (G[k] != 0)
                    {
                        delel = k;
                        for (int p = 0; p < Matrix.Length; p++)
                            for (int j = 0; j < Matrix[p].Length; j++)
                                if (p == delel || j == delel)
                                    Matrix[p][j] = 0;
                    }
                Output_Matrix(Matrix, dataGridView2);
                newstartindex(G, ref i);
                for (int k = 0; k < Tp.Length; k++)
                {
                    Tp[k] = 0;
                    Tm[k] = 0;
                    G[k] = 0;
                }
            }
                    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BCalc.Visible = true;
            inpfromfile = false;
            MessageBox.Show("Будут использованы условия заданные в варианте №9");
        }

        //private void BInpfromfile_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            TBG.Clear();
        //            TBTminus.Clear();
        //            TBTplus.Clear();
        //        }
        //        else
        //            throw new FormatException("Файл не выбран");
        //        string fn = openFileDialog1.FileName;
        //        StreamReader fin = new StreamReader(fn);
        //        string str;
        //        string[] str2;
        //        for (int i = 0; (str = fin.ReadLine()) != null; i++)
        //        {
        //            str2 = str.Split(new char[] { ' ' });
        //            Matrix[i] = new int[Matrix.Length];
        //            for (int j = 0; j < Matrix.Length; j++)
        //            {
        //                Matrix[i][j] = Convert.ToInt32(str2[j]);
        //            }
        //        }
        //        fin.Close();
        //    }
        //    catch (FormatException Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //}
    }
}
НУ КАК ЖЕ ЧЕРТ подери это скучно


