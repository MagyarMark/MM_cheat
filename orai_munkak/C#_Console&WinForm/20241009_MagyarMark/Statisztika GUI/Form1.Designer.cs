namespace Statisztika_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_stat = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txbFileName = new System.Windows.Forms.TextBox();
            this.txbSector = new System.Windows.Forms.TextBox();
            this.lbl2feladat = new System.Windows.Forms.Label();
            this.lbl3feladat = new System.Windows.Forms.Label();
            this.lbl4_1feladat = new System.Windows.Forms.Label();
            this.lbl4_2feladat = new System.Windows.Forms.Label();
            this.lbl5_2feladat = new System.Windows.Forms.Label();
            this.lbl5_1feladat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "2. feladat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "3. feladat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "4.feladat  Szektor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "5. feladat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(610, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kérem a file nevét:";
            // 
            // btn_stat
            // 
            this.btn_stat.Location = new System.Drawing.Point(593, 62);
            this.btn_stat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_stat.Name = "btn_stat";
            this.btn_stat.Size = new System.Drawing.Size(162, 52);
            this.btn_stat.TabIndex = 5;
            this.btn_stat.Text = "Statisztika";
            this.btn_stat.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(357, 286);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(414, 162);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "vége";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txbFileName
            // 
            this.txbFileName.Location = new System.Drawing.Point(593, 30);
            this.txbFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbFileName.Name = "txbFileName";
            this.txbFileName.Size = new System.Drawing.Size(162, 20);
            this.txbFileName.TabIndex = 7;
            this.txbFileName.Text = "dobasok.txt";
            // 
            // txbSector
            // 
            this.txbSector.Location = new System.Drawing.Point(134, 168);
            this.txbSector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbSector.Name = "txbSector";
            this.txbSector.Size = new System.Drawing.Size(116, 20);
            this.txbSector.TabIndex = 8;
            this.txbSector.Text = "D16";
            // 
            // lbl2feladat
            // 
            this.lbl2feladat.AutoSize = true;
            this.lbl2feladat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2feladat.Location = new System.Drawing.Point(19, 30);
            this.lbl2feladat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2feladat.Name = "lbl2feladat";
            this.lbl2feladat.Size = new System.Drawing.Size(41, 13);
            this.lbl2feladat.TabIndex = 9;
            this.lbl2feladat.Text = "lbl2fel";
            // 
            // lbl3feladat
            // 
            this.lbl3feladat.AutoSize = true;
            this.lbl3feladat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3feladat.Location = new System.Drawing.Point(18, 99);
            this.lbl3feladat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3feladat.Name = "lbl3feladat";
            this.lbl3feladat.Size = new System.Drawing.Size(41, 13);
            this.lbl3feladat.TabIndex = 10;
            this.lbl3feladat.Text = "lbl3fel";
            // 
            // lbl4_1feladat
            // 
            this.lbl4_1feladat.AutoSize = true;
            this.lbl4_1feladat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl4_1feladat.Location = new System.Drawing.Point(21, 198);
            this.lbl4_1feladat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4_1feladat.Name = "lbl4_1feladat";
            this.lbl4_1feladat.Size = new System.Drawing.Size(80, 13);
            this.lbl4_1feladat.TabIndex = 11;
            this.lbl4_1feladat.Text = "lbl4_1feladat";
            // 
            // lbl4_2feladat
            // 
            this.lbl4_2feladat.AutoSize = true;
            this.lbl4_2feladat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl4_2feladat.Location = new System.Drawing.Point(21, 215);
            this.lbl4_2feladat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4_2feladat.Name = "lbl4_2feladat";
            this.lbl4_2feladat.Size = new System.Drawing.Size(80, 13);
            this.lbl4_2feladat.TabIndex = 12;
            this.lbl4_2feladat.Text = "lbl4_2feladat";
            // 
            // lbl5_2feladat
            // 
            this.lbl5_2feladat.AutoSize = true;
            this.lbl5_2feladat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl5_2feladat.Location = new System.Drawing.Point(21, 332);
            this.lbl5_2feladat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5_2feladat.Name = "lbl5_2feladat";
            this.lbl5_2feladat.Size = new System.Drawing.Size(80, 13);
            this.lbl5_2feladat.TabIndex = 14;
            this.lbl5_2feladat.Text = "lbl5_2feladat";
            // 
            // lbl5_1feladat
            // 
            this.lbl5_1feladat.AutoSize = true;
            this.lbl5_1feladat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl5_1feladat.Location = new System.Drawing.Point(21, 308);
            this.lbl5_1feladat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5_1feladat.Name = "lbl5_1feladat";
            this.lbl5_1feladat.Size = new System.Drawing.Size(80, 13);
            this.lbl5_1feladat.TabIndex = 13;
            this.lbl5_1feladat.Text = "lbl5_1feladat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 447);
            this.Controls.Add(this.lbl5_2feladat);
            this.Controls.Add(this.lbl5_1feladat);
            this.Controls.Add(this.lbl4_2feladat);
            this.Controls.Add(this.lbl4_1feladat);
            this.Controls.Add(this.lbl3feladat);
            this.Controls.Add(this.lbl2feladat);
            this.Controls.Add(this.txbSector);
            this.Controls.Add(this.txbFileName);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_stat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Más";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_stat;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txbFileName;
        private System.Windows.Forms.TextBox txbSector;
        private System.Windows.Forms.Label lbl2feladat;
        private System.Windows.Forms.Label lbl3feladat;
        private System.Windows.Forms.Label lbl4_1feladat;
        private System.Windows.Forms.Label lbl4_2feladat;
        private System.Windows.Forms.Label lbl5_2feladat;
        private System.Windows.Forms.Label lbl5_1feladat;
    }
}

