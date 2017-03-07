namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserLB = new System.Windows.Forms.ListBox();
            this.BookLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UserLB
            // 
            this.UserLB.FormattingEnabled = true;
            this.UserLB.Location = new System.Drawing.Point(12, 24);
            this.UserLB.Name = "UserLB";
            this.UserLB.Size = new System.Drawing.Size(269, 264);
            this.UserLB.TabIndex = 0;
            // 
            // BookLB
            // 
            this.BookLB.FormattingEnabled = true;
            this.BookLB.Location = new System.Drawing.Point(432, 24);
            this.BookLB.Name = "BookLB";
            this.BookLB.Size = new System.Drawing.Size(269, 264);
            this.BookLB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 433);
            this.Controls.Add(this.BookLB);
            this.Controls.Add(this.UserLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UserLB;
        private System.Windows.Forms.ListBox BookLB;
    }
}

