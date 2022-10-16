namespace AutoNyilvantartas
{
    partial class FormNyito
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
            this.cbAutok = new System.Windows.Forms.ComboBox();
            this.lbAdatok = new System.Windows.Forms.ListBox();
            this.btUj = new System.Windows.Forms.Button();
            this.btModosit = new System.Windows.Forms.Button();
            this.btTorol = new System.Windows.Forms.Button();
            this.btTeljesLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAutok
            // 
            this.cbAutok.FormattingEnabled = true;
            this.cbAutok.Location = new System.Drawing.Point(13, 12);
            this.cbAutok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAutok.Name = "cbAutok";
            this.cbAutok.Size = new System.Drawing.Size(165, 28);
            this.cbAutok.TabIndex = 0;
            this.cbAutok.Text = "Válassz egy márkát";
            this.cbAutok.SelectedIndexChanged += new System.EventHandler(this.cbAutok_SelectedIndexChanged);
            // 
            // lbAdatok
            // 
            this.lbAdatok.FormattingEnabled = true;
            this.lbAdatok.ItemHeight = 20;
            this.lbAdatok.Location = new System.Drawing.Point(13, 110);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(734, 484);
            this.lbAdatok.TabIndex = 1;
            // 
            // btUj
            // 
            this.btUj.Location = new System.Drawing.Point(202, 9);
            this.btUj.Name = "btUj";
            this.btUj.Size = new System.Drawing.Size(165, 33);
            this.btUj.TabIndex = 2;
            this.btUj.Text = "Új autó felvétele";
            this.btUj.UseVisualStyleBackColor = true;
            this.btUj.Click += new System.EventHandler(this.btUj_Click);
            // 
            // btModosit
            // 
            this.btModosit.Location = new System.Drawing.Point(391, 7);
            this.btModosit.Name = "btModosit";
            this.btModosit.Size = new System.Drawing.Size(165, 33);
            this.btModosit.TabIndex = 3;
            this.btModosit.Text = "Meglévő módosítása";
            this.btModosit.UseVisualStyleBackColor = true;
            this.btModosit.Click += new System.EventHandler(this.btModosit_Click);
            // 
            // btTorol
            // 
            this.btTorol.Location = new System.Drawing.Point(580, 7);
            this.btTorol.Name = "btTorol";
            this.btTorol.Size = new System.Drawing.Size(165, 33);
            this.btTorol.TabIndex = 4;
            this.btTorol.Text = "Meglévő törlése";
            this.btTorol.UseVisualStyleBackColor = true;
            this.btTorol.Click += new System.EventHandler(this.btTorol_Click);
            // 
            // btTeljesLista
            // 
            this.btTeljesLista.Location = new System.Drawing.Point(13, 60);
            this.btTeljesLista.Name = "btTeljesLista";
            this.btTeljesLista.Size = new System.Drawing.Size(165, 33);
            this.btTeljesLista.TabIndex = 5;
            this.btTeljesLista.Text = "Teljes lista";
            this.btTeljesLista.UseVisualStyleBackColor = true;
            this.btTeljesLista.Click += new System.EventHandler(this.btTeljesLista_Click);
            // 
            // FormNyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 610);
            this.Controls.Add(this.btTeljesLista);
            this.Controls.Add(this.btTorol);
            this.Controls.Add(this.btModosit);
            this.Controls.Add(this.btUj);
            this.Controls.Add(this.lbAdatok);
            this.Controls.Add(this.cbAutok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNyito";
            this.Text = "Autók adatai";
            this.Load += new System.EventHandler(this.FormNyito_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAutok;
        private System.Windows.Forms.Button btUj;
        private System.Windows.Forms.Button btModosit;
        private System.Windows.Forms.Button btTorol;
        public System.Windows.Forms.ListBox lbAdatok;
        private System.Windows.Forms.Button btTeljesLista;
    }
}

