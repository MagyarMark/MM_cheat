namespace RealEstateGUI
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
            this.hbe = new System.Windows.Forms.Button();
            this.hSzam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hName = new System.Windows.Forms.Label();
            this.hTel = new System.Windows.Forms.Label();
            this.hTer = new System.Windows.Forms.Label();
            this.hSzoba = new System.Windows.Forms.Label();
            this.hEmelet = new System.Windows.Forms.Label();
            this.hLeir = new System.Windows.Forms.Label();
            this.hCreate = new System.Windows.Forms.Label();
            this.hFree = new System.Windows.Forms.Label();
            this.hImg = new System.Windows.Forms.Label();
            this.hLat = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hbe
            // 
            this.hbe.Location = new System.Drawing.Point(422, 78);
            this.hbe.Name = "hbe";
            this.hbe.Size = new System.Drawing.Size(335, 24);
            this.hbe.TabIndex = 6;
            this.hbe.Text = "Hírdetések betöltése";
            this.hbe.UseVisualStyleBackColor = true;
            this.hbe.Click += new System.EventHandler(this.hbe_Click);
            // 
            // hSzam
            // 
            this.hSzam.Location = new System.Drawing.Point(393, 105);
            this.hSzam.Name = "hSzam";
            this.hSzam.Size = new System.Drawing.Size(23, 23);
            this.hSzam.TabIndex = 9;
            this.hSzam.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hírdetések száma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eladó telefonszáma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eladó neve:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(422, 0);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(249, 56);
            this.nev.TabIndex = 8;
            this.nev.Text = "name";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(422, 59);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(273, 16);
            this.tel.TabIndex = 7;
            this.tel.Text = "tel";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 53);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.43689F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.56311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.hSzam, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.hbe, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nev, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.hName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.hTel, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.hSzoba, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.hTer, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.hEmelet, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.hLeir, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.hCreate, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.hFree, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.hLat, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.hImg, 3, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // hName
            // 
            this.hName.Location = new System.Drawing.Point(258, 132);
            this.hName.Name = "hName";
            this.hName.Size = new System.Drawing.Size(129, 23);
            this.hName.TabIndex = 10;
            this.hName.Text = "nev";
            // 
            // hTel
            // 
            this.hTel.Location = new System.Drawing.Point(422, 132);
            this.hTel.Name = "hTel";
            this.hTel.Size = new System.Drawing.Size(249, 23);
            this.hTel.TabIndex = 11;
            this.hTel.Text = "tel";
            // 
            // hTer
            // 
            this.hTer.Location = new System.Drawing.Point(258, 155);
            this.hTer.Name = "hTer";
            this.hTer.Size = new System.Drawing.Size(129, 23);
            this.hTer.TabIndex = 12;
            this.hTer.Text = "ter";
            // 
            // hSzoba
            // 
            this.hSzoba.Location = new System.Drawing.Point(422, 155);
            this.hSzoba.Name = "hSzoba";
            this.hSzoba.Size = new System.Drawing.Size(129, 23);
            this.hSzoba.TabIndex = 13;
            this.hSzoba.Text = "Szob";
            // 
            // hEmelet
            // 
            this.hEmelet.Location = new System.Drawing.Point(258, 182);
            this.hEmelet.Name = "hEmelet";
            this.hEmelet.Size = new System.Drawing.Size(129, 23);
            this.hEmelet.TabIndex = 14;
            this.hEmelet.Text = "Emelet";
            // 
            // hLeir
            // 
            this.hLeir.Location = new System.Drawing.Point(422, 182);
            this.hLeir.Name = "hLeir";
            this.hLeir.Size = new System.Drawing.Size(129, 22);
            this.hLeir.TabIndex = 15;
            this.hLeir.Text = "Leírás";
            // 
            // hCreate
            // 
            this.hCreate.Location = new System.Drawing.Point(258, 212);
            this.hCreate.Name = "hCreate";
            this.hCreate.Size = new System.Drawing.Size(129, 22);
            this.hCreate.TabIndex = 16;
            this.hCreate.Text = "Create";
            // 
            // hFree
            // 
            this.hFree.Location = new System.Drawing.Point(422, 212);
            this.hFree.Name = "hFree";
            this.hFree.Size = new System.Drawing.Size(129, 22);
            this.hFree.TabIndex = 17;
            this.hFree.Text = "Free";
            // 
            // hImg
            // 
            this.hImg.Location = new System.Drawing.Point(422, 262);
            this.hImg.Name = "hImg";
            this.hImg.Size = new System.Drawing.Size(366, 80);
            this.hImg.TabIndex = 18;
            this.hImg.Text = "img";
            // 
            // hLat
            // 
            this.hLat.Location = new System.Drawing.Point(422, 240);
            this.hLat.Name = "hLat";
            this.hLat.Size = new System.Drawing.Size(366, 22);
            this.hLat.TabIndex = 19;
            this.hLat.Text = "lat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Ingatlanok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hbe;
        private System.Windows.Forms.Label hSzam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label hName;
        private System.Windows.Forms.Label hTel;
        private System.Windows.Forms.Label hTer;
        private System.Windows.Forms.Label hSzoba;
        private System.Windows.Forms.Label hEmelet;
        private System.Windows.Forms.Label hLeir;
        private System.Windows.Forms.Label hCreate;
        private System.Windows.Forms.Label hFree;
        private System.Windows.Forms.Label hImg;
        private System.Windows.Forms.Label hLat;
    }
}

