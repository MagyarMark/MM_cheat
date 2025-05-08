namespace First_forms
{
    partial class alap_ablak
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.chb_plus = new System.Windows.Forms.CheckBox();
            this.chb_division = new System.Windows.Forms.CheckBox();
            this.chb_dives = new System.Windows.Forms.CheckBox();
            this.chb_minus = new System.Windows.Forms.CheckBox();
            this.txb_elso = new System.Windows.Forms.TextBox();
            this.txb_masodik = new System.Windows.Forms.TextBox();
            this.lbl_eredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(566, 317);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(242, 135);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Button 1";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // chb_plus
            // 
            this.chb_plus.AutoSize = true;
            this.chb_plus.Location = new System.Drawing.Point(104, 12);
            this.chb_plus.Name = "chb_plus";
            this.chb_plus.Size = new System.Drawing.Size(32, 17);
            this.chb_plus.TabIndex = 1;
            this.chb_plus.Text = "+";
            this.chb_plus.UseVisualStyleBackColor = true;
            this.chb_plus.CheckedChanged += new System.EventHandler(this.chb_plus_CheckedChanged);
            // 
            // chb_division
            // 
            this.chb_division.AutoSize = true;
            this.chb_division.Location = new System.Drawing.Point(104, 81);
            this.chb_division.Name = "chb_division";
            this.chb_division.Size = new System.Drawing.Size(31, 17);
            this.chb_division.TabIndex = 2;
            this.chb_division.Text = "/";
            this.chb_division.UseVisualStyleBackColor = true;
            this.chb_division.CheckedChanged += new System.EventHandler(this.chb_division_CheckedChanged);
            // 
            // chb_dives
            // 
            this.chb_dives.AutoSize = true;
            this.chb_dives.Location = new System.Drawing.Point(104, 58);
            this.chb_dives.Name = "chb_dives";
            this.chb_dives.Size = new System.Drawing.Size(30, 17);
            this.chb_dives.TabIndex = 3;
            this.chb_dives.Text = "*";
            this.chb_dives.UseVisualStyleBackColor = true;
            this.chb_dives.CheckedChanged += new System.EventHandler(this.chb_dives_CheckedChanged);
            // 
            // chb_minus
            // 
            this.chb_minus.AutoSize = true;
            this.chb_minus.Location = new System.Drawing.Point(104, 35);
            this.chb_minus.Name = "chb_minus";
            this.chb_minus.Size = new System.Drawing.Size(29, 17);
            this.chb_minus.TabIndex = 4;
            this.chb_minus.Text = "-";
            this.chb_minus.UseVisualStyleBackColor = true;
            this.chb_minus.CheckedChanged += new System.EventHandler(this.chb_minus_CheckedChanged);
            // 
            // txb_elso
            // 
            this.txb_elso.Location = new System.Drawing.Point(-2, 35);
            this.txb_elso.Name = "txb_elso";
            this.txb_elso.Size = new System.Drawing.Size(100, 20);
            this.txb_elso.TabIndex = 5;
            // 
            // txb_masodik
            // 
            this.txb_masodik.Location = new System.Drawing.Point(140, 34);
            this.txb_masodik.Name = "txb_masodik";
            this.txb_masodik.Size = new System.Drawing.Size(100, 20);
            this.txb_masodik.TabIndex = 6;
            // 
            // lbl_eredmeny
            // 
            this.lbl_eredmeny.AutoSize = true;
            this.lbl_eredmeny.Location = new System.Drawing.Point(246, 38);
            this.lbl_eredmeny.Name = "lbl_eredmeny";
            this.lbl_eredmeny.Size = new System.Drawing.Size(13, 13);
            this.lbl_eredmeny.TabIndex = 7;
            this.lbl_eredmeny.Text = "=";
            // 
            // alap_ablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 464);
            this.Controls.Add(this.lbl_eredmeny);
            this.Controls.Add(this.txb_masodik);
            this.Controls.Add(this.txb_elso);
            this.Controls.Add(this.chb_minus);
            this.Controls.Add(this.chb_dives);
            this.Controls.Add(this.chb_division);
            this.Controls.Add(this.chb_plus);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "alap_ablak";
            this.Text = "First Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.CheckBox chb_plus;
        private System.Windows.Forms.CheckBox chb_division;
        private System.Windows.Forms.CheckBox chb_dives;
        private System.Windows.Forms.CheckBox chb_minus;
        private System.Windows.Forms.TextBox txb_elso;
        private System.Windows.Forms.TextBox txb_masodik;
        private System.Windows.Forms.Label lbl_eredmeny;
    }
}

