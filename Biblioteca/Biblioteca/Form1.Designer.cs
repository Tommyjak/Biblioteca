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
            this.infoBook = new System.Windows.Forms.Button();
            this.infoUser = new System.Windows.Forms.Button();
            this.PrestaOut = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.prestaButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLB
            // 
            this.UserLB.FormattingEnabled = true;
            this.UserLB.HorizontalScrollbar = true;
            this.UserLB.Location = new System.Drawing.Point(12, 24);
            this.UserLB.Name = "UserLB";
            this.UserLB.Size = new System.Drawing.Size(174, 264);
            this.UserLB.TabIndex = 0;
            // 
            // BookLB
            // 
            this.BookLB.FormattingEnabled = true;
            this.BookLB.HorizontalScrollbar = true;
            this.BookLB.Location = new System.Drawing.Point(559, 24);
            this.BookLB.Name = "BookLB";
            this.BookLB.Size = new System.Drawing.Size(160, 264);
            this.BookLB.TabIndex = 1;
            // 
            // infoBook
            // 
            this.infoBook.Location = new System.Drawing.Point(608, 324);
            this.infoBook.Name = "infoBook";
            this.infoBook.Size = new System.Drawing.Size(75, 23);
            this.infoBook.TabIndex = 2;
            this.infoBook.Text = "infoBook";
            this.infoBook.UseVisualStyleBackColor = true;
            this.infoBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoUser
            // 
            this.infoUser.Location = new System.Drawing.Point(62, 324);
            this.infoUser.Name = "infoUser";
            this.infoUser.Size = new System.Drawing.Size(75, 23);
            this.infoUser.TabIndex = 3;
            this.infoUser.Text = "infoUser";
            this.infoUser.UseVisualStyleBackColor = true;
            this.infoUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // PrestaOut
            // 
            this.PrestaOut.Location = new System.Drawing.Point(297, 24);
            this.PrestaOut.Multiline = true;
            this.PrestaOut.Name = "PrestaOut";
            this.PrestaOut.Size = new System.Drawing.Size(169, 264);
            this.PrestaOut.TabIndex = 5;
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(12, 364);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(689, 180);
            this.infoBox.TabIndex = 6;
            // 
            // prestaButt
            // 
            this.prestaButt.Location = new System.Drawing.Point(347, 324);
            this.prestaButt.Name = "prestaButt";
            this.prestaButt.Size = new System.Drawing.Size(75, 23);
            this.prestaButt.TabIndex = 7;
            this.prestaButt.Text = "presta";
            this.prestaButt.UseVisualStyleBackColor = true;
            this.prestaButt.Click += new System.EventHandler(this.prestaButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 556);
            this.Controls.Add(this.prestaButt);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.PrestaOut);
            this.Controls.Add(this.infoUser);
            this.Controls.Add(this.infoBook);
            this.Controls.Add(this.BookLB);
            this.Controls.Add(this.UserLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox BookLB;
        private System.Windows.Forms.Button infoBook;
        private System.Windows.Forms.Button infoUser;
        private System.Windows.Forms.ListBox UserLB;
        private System.Windows.Forms.TextBox PrestaOut;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Button prestaButt;
    }
}

