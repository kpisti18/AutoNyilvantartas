namespace AutoNyilvantartas
{
    partial class FormAuto
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTipus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btMuvelet = new System.Windows.Forms.Button();
            this.tbRendszam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(113, 36);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(144, 26);
            this.tbID.TabIndex = 1;
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(113, 200);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(252, 26);
            this.tbMarka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Márka";
            // 
            // tbTipus
            // 
            this.tbTipus.Location = new System.Drawing.Point(113, 297);
            this.tbTipus.Name = "tbTipus";
            this.tbTipus.Size = new System.Drawing.Size(252, 26);
            this.tbTipus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Típus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 407);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forgalomba helyezés éve";
            // 
            // btMuvelet
            // 
            this.btMuvelet.Location = new System.Drawing.Point(39, 488);
            this.btMuvelet.Name = "btMuvelet";
            this.btMuvelet.Size = new System.Drawing.Size(341, 47);
            this.btMuvelet.TabIndex = 8;
            this.btMuvelet.Text = "button1";
            this.btMuvelet.UseVisualStyleBackColor = true;
            this.btMuvelet.Click += new System.EventHandler(this.btMuvelet_Click);
            // 
            // tbRendszam
            // 
            this.tbRendszam.Location = new System.Drawing.Point(113, 123);
            this.tbRendszam.Name = "tbRendszam";
            this.tbRendszam.Size = new System.Drawing.Size(252, 26);
            this.tbRendszam.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rendszám";
            // 
            // tbEv
            // 
            this.tbEv.Location = new System.Drawing.Point(222, 404);
            this.tbEv.Name = "tbEv";
            this.tbEv.Size = new System.Drawing.Size(143, 26);
            this.tbEv.TabIndex = 11;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 576);
            this.Controls.Add(this.tbEv);
            this.Controls.Add(this.tbRendszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btMuvelet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTipus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAuto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTipus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btMuvelet;
        private System.Windows.Forms.TextBox tbRendszam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEv;
    }
}