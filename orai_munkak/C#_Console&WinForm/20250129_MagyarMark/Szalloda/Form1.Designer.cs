namespace Szalloda
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnKi = new System.Windows.Forms.Button();
            this.BtnVissza = new System.Windows.Forms.Button();
            this.BtnTel = new System.Windows.Forms.Button();
            this.BtnStat = new System.Windows.Forms.Button();
            this.BtnFoglalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Import txt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Január",
            "Február",
            "Március",
            "Április",
            "Május",
            "Június",
            "Július",
            "Augusztus",
            "Szeptember",
            "Október",
            "November",
            "December"});
            this.comboBox2.Location = new System.Drawing.Point(370, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 32);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "Január";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.comboBox1.Location = new System.Drawing.Point(247, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 32);
            this.comboBox1.TabIndex = 13;
            // 
            // BtnKi
            // 
            this.BtnKi.Location = new System.Drawing.Point(807, 361);
            this.BtnKi.Name = "BtnKi";
            this.BtnKi.Size = new System.Drawing.Size(116, 58);
            this.BtnKi.TabIndex = 12;
            this.BtnKi.Text = "Kilépés";
            this.BtnKi.UseVisualStyleBackColor = true;
            // 
            // BtnVissza
            // 
            this.BtnVissza.Location = new System.Drawing.Point(807, 361);
            this.BtnVissza.Name = "BtnVissza";
            this.BtnVissza.Size = new System.Drawing.Size(116, 58);
            this.BtnVissza.TabIndex = 11;
            this.BtnVissza.Text = "Vissza";
            this.BtnVissza.UseVisualStyleBackColor = true;
            // 
            // BtnTel
            // 
            this.BtnTel.Location = new System.Drawing.Point(807, 117);
            this.BtnTel.Name = "BtnTel";
            this.BtnTel.Size = new System.Drawing.Size(116, 58);
            this.BtnTel.TabIndex = 10;
            this.BtnTel.Text = "Telefon";
            this.BtnTel.UseVisualStyleBackColor = true;
            // 
            // BtnStat
            // 
            this.BtnStat.Location = new System.Drawing.Point(807, 195);
            this.BtnStat.Name = "BtnStat";
            this.BtnStat.Size = new System.Drawing.Size(116, 58);
            this.BtnStat.TabIndex = 9;
            this.BtnStat.Text = "Statisztika";
            this.BtnStat.UseVisualStyleBackColor = true;
            // 
            // BtnFoglalas
            // 
            this.BtnFoglalas.Location = new System.Drawing.Point(807, 275);
            this.BtnFoglalas.Name = "BtnFoglalas";
            this.BtnFoglalas.Size = new System.Drawing.Size(116, 58);
            this.BtnFoglalas.TabIndex = 8;
            this.BtnFoglalas.Text = "Foglalás";
            this.BtnFoglalas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(957, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnKi);
            this.Controls.Add(this.BtnVissza);
            this.Controls.Add(this.BtnTel);
            this.Controls.Add(this.BtnStat);
            this.Controls.Add(this.BtnFoglalas);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button telBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button foglalasokBtn;
        private System.Windows.Forms.Button StatsBtn;
        private System.Windows.Forms.ComboBox yearComBox;
        private System.Windows.Forms.ComboBox monthComBox;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label dbglabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.TextBox szobaTxtBox;
        private System.Windows.Forms.Label szobaTxt;
        private System.Windows.Forms.Label szmelyektxt;
        private System.Windows.Forms.TextBox szemlyekTxtBox;
        private System.Windows.Forms.RadioButton NemRadio;
        private System.Windows.Forms.RadioButton igenRadio;
        private System.Windows.Forms.Label breakfastTxt;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnKi;
        private System.Windows.Forms.Button BtnVissza;
        private System.Windows.Forms.Button BtnTel;
        private System.Windows.Forms.Button BtnStat;
        private System.Windows.Forms.Button BtnFoglalas;
    }
}

