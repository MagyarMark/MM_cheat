namespace Dolgozat
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
            this.BtnFoglalas = new System.Windows.Forms.Button();
            this.BtnStat = new System.Windows.Forms.Button();
            this.BtnTel = new System.Windows.Forms.Button();
            this.BtnVissza = new System.Windows.Forms.Button();
            this.BtnKi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFoglalas
            // 
            this.BtnFoglalas.Location = new System.Drawing.Point(704, 258);
            this.BtnFoglalas.Name = "BtnFoglalas";
            this.BtnFoglalas.Size = new System.Drawing.Size(116, 58);
            this.BtnFoglalas.TabIndex = 0;
            this.BtnFoglalas.Text = "Foglalás";
            this.BtnFoglalas.UseVisualStyleBackColor = true;
            this.BtnFoglalas.Click += new System.EventHandler(this.BtnFoglalas_Click);
            // 
            // BtnStat
            // 
            this.BtnStat.Location = new System.Drawing.Point(704, 178);
            this.BtnStat.Name = "BtnStat";
            this.BtnStat.Size = new System.Drawing.Size(116, 58);
            this.BtnStat.TabIndex = 1;
            this.BtnStat.Text = "Statisztika";
            this.BtnStat.UseVisualStyleBackColor = true;
            this.BtnStat.Click += new System.EventHandler(this.BtnStat_Click);
            // 
            // BtnTel
            // 
            this.BtnTel.Location = new System.Drawing.Point(704, 100);
            this.BtnTel.Name = "BtnTel";
            this.BtnTel.Size = new System.Drawing.Size(116, 58);
            this.BtnTel.TabIndex = 2;
            this.BtnTel.Text = "Telefon";
            this.BtnTel.UseVisualStyleBackColor = true;
            this.BtnTel.Click += new System.EventHandler(this.BtnTel_Click);
            // 
            // BtnVissza
            // 
            this.BtnVissza.Location = new System.Drawing.Point(704, 344);
            this.BtnVissza.Name = "BtnVissza";
            this.BtnVissza.Size = new System.Drawing.Size(116, 58);
            this.BtnVissza.TabIndex = 3;
            this.BtnVissza.Text = "Vissza";
            this.BtnVissza.UseVisualStyleBackColor = true;
            this.BtnVissza.Click += new System.EventHandler(this.BtnVissza_Click);
            // 
            // BtnKi
            // 
            this.BtnKi.Location = new System.Drawing.Point(704, 344);
            this.BtnKi.Name = "BtnKi";
            this.BtnKi.Size = new System.Drawing.Size(116, 58);
            this.BtnKi.TabIndex = 4;
            this.BtnKi.Text = "Kilépés";
            this.BtnKi.UseVisualStyleBackColor = true;
            this.BtnKi.Click += new System.EventHandler(this.BtnKi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 32);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(267, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 32);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Import txt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnKi);
            this.Controls.Add(this.BtnVissza);
            this.Controls.Add(this.BtnTel);
            this.Controls.Add(this.BtnStat);
            this.Controls.Add(this.BtnFoglalas);
            this.Name = "Form1";
            this.Text = "Szálloda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFoglalas;
        private System.Windows.Forms.Button BtnStat;
        private System.Windows.Forms.Button BtnTel;
        private System.Windows.Forms.Button BtnVissza;
        private System.Windows.Forms.Button BtnKi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}

