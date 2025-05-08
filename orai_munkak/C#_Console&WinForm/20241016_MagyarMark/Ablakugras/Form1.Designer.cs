namespace Ablakugras
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
            this.bal_felso = new System.Windows.Forms.Button();
            this.bal_also = new System.Windows.Forms.Button();
            this.jobb_felso = new System.Windows.Forms.Button();
            this.jobb_also = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bal_felso
            // 
            this.bal_felso.Location = new System.Drawing.Point(52, 56);
            this.bal_felso.Name = "bal_felso";
            this.bal_felso.Size = new System.Drawing.Size(272, 130);
            this.bal_felso.TabIndex = 0;
            this.bal_felso.Text = "Bal Felső";
            this.bal_felso.UseVisualStyleBackColor = true;
            this.bal_felso.Click += new System.EventHandler(this.bal_felso_Click);
            // 
            // bal_also
            // 
            this.bal_also.Location = new System.Drawing.Point(52, 259);
            this.bal_also.Name = "bal_also";
            this.bal_also.Size = new System.Drawing.Size(272, 133);
            this.bal_also.TabIndex = 1;
            this.bal_also.Text = "bal alsó";
            this.bal_also.UseVisualStyleBackColor = true;
            this.bal_also.Click += new System.EventHandler(this.bal_also_Click);
            // 
            // jobb_felso
            // 
            this.jobb_felso.Location = new System.Drawing.Point(456, 56);
            this.jobb_felso.Name = "jobb_felso";
            this.jobb_felso.Size = new System.Drawing.Size(272, 130);
            this.jobb_felso.TabIndex = 2;
            this.jobb_felso.Text = "Jobb felső";
            this.jobb_felso.UseVisualStyleBackColor = true;
            this.jobb_felso.Click += new System.EventHandler(this.jobb_felso_Click);
            // 
            // jobb_also
            // 
            this.jobb_also.Location = new System.Drawing.Point(456, 259);
            this.jobb_also.Name = "jobb_also";
            this.jobb_also.Size = new System.Drawing.Size(272, 130);
            this.jobb_also.TabIndex = 3;
            this.jobb_also.Text = "Jobb alsó";
            this.jobb_also.UseVisualStyleBackColor = true;
            this.jobb_also.Click += new System.EventHandler(this.jobb_also_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jobb_also);
            this.Controls.Add(this.jobb_felso);
            this.Controls.Add(this.bal_also);
            this.Controls.Add(this.bal_felso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bal_felso;
        private System.Windows.Forms.Button bal_also;
        private System.Windows.Forms.Button jobb_felso;
        private System.Windows.Forms.Button jobb_also;
    }
}

