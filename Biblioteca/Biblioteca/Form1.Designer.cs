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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PrestaOut = new System.Windows.Forms.TextBox();
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
            this.BookLB.Size = new System.Drawing.Size(142, 264);
            this.BookLB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // PrestaOut
            // 
            this.PrestaOut.Location = new System.Drawing.Point(297, 24);
            this.PrestaOut.Multiline = true;
            this.PrestaOut.Name = "PrestaOut";
            this.PrestaOut.Size = new System.Drawing.Size(169, 264);
            this.PrestaOut.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 433);
            this.Controls.Add(this.PrestaOut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BookLB);
            this.Controls.Add(this.UserLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox BookLB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox UserLB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PrestaOut;
    }
}

