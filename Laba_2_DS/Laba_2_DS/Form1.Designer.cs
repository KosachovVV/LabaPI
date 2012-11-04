namespace Laba_2_DS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BInpfromfile = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BCalc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TBTplus = new System.Windows.Forms.TextBox();
            this.TBTminus = new System.Windows.Forms.TextBox();
            this.TBG = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Busestdvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BInpfromfile
            // 
            this.BInpfromfile.Location = new System.Drawing.Point(12, 387);
            this.BInpfromfile.Name = "BInpfromfile";
            this.BInpfromfile.Size = new System.Drawing.Size(75, 38);
            this.BInpfromfile.TabIndex = 0;
            this.BInpfromfile.Text = "Ввод из  файла";
            this.BInpfromfile.UseVisualStyleBackColor = true;
            this.BInpfromfile.Visible = false;
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(518, 395);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(75, 23);
            this.BExit.TabIndex = 1;
            this.BExit.Text = "Выход";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BCalc
            // 
            this.BCalc.Location = new System.Drawing.Point(265, 395);
            this.BCalc.Name = "BCalc";
            this.BCalc.Size = new System.Drawing.Size(75, 23);
            this.BCalc.TabIndex = 2;
            this.BCalc.Text = "Вычислить";
            this.BCalc.UseVisualStyleBackColor = true;
            this.BCalc.Visible = false;
            this.BCalc.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 187);
            this.dataGridView1.TabIndex = 4;
            // 
            // TBTplus
            // 
            this.TBTplus.Location = new System.Drawing.Point(12, 205);
            this.TBTplus.Multiline = true;
            this.TBTplus.Name = "TBTplus";
            this.TBTplus.ReadOnly = true;
            this.TBTplus.Size = new System.Drawing.Size(165, 152);
            this.TBTplus.TabIndex = 5;
            // 
            // TBTminus
            // 
            this.TBTminus.Location = new System.Drawing.Point(221, 205);
            this.TBTminus.Multiline = true;
            this.TBTminus.Name = "TBTminus";
            this.TBTminus.ReadOnly = true;
            this.TBTminus.Size = new System.Drawing.Size(167, 152);
            this.TBTminus.TabIndex = 6;
            // 
            // TBG
            // 
            this.TBG.Location = new System.Drawing.Point(426, 205);
            this.TBG.Multiline = true;
            this.TBG.Name = "TBG";
            this.TBG.ReadOnly = true;
            this.TBG.Size = new System.Drawing.Size(167, 152);
            this.TBG.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(353, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 187);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.Visible = false;
            // 
            // Busestdvar
            // 
            this.Busestdvar.Location = new System.Drawing.Point(93, 388);
            this.Busestdvar.Name = "Busestdvar";
            this.Busestdvar.Size = new System.Drawing.Size(75, 37);
            this.Busestdvar.TabIndex = 9;
            this.Busestdvar.Text = "В соотв. с вариантом";
            this.Busestdvar.UseVisualStyleBackColor = true;
            this.Busestdvar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 457);
            this.Controls.Add(this.Busestdvar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.TBG);
            this.Controls.Add(this.TBTminus);
            this.Controls.Add(this.TBTplus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BCalc);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BInpfromfile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS_Laba_2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BInpfromfile;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BCalc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBTplus;
        private System.Windows.Forms.TextBox TBTminus;
        private System.Windows.Forms.TextBox TBG;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Busestdvar;
    }
}

