namespace BRITGAME
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
            this.components = new System.ComponentModel.Container();
            this.rek = new System.Windows.Forms.PictureBox();
            this.check = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rek)).BeginInit();
            this.SuspendLayout();
            // 
            // rek
            // 
            this.rek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rek.Location = new System.Drawing.Point(358, 406);
            this.rek.Name = "rek";
            this.rek.Size = new System.Drawing.Size(185, 104);
            this.rek.TabIndex = 0;
            this.rek.TabStop = false;
            // 
            // check
            // 
            this.check.Interval = 1;
            this.check.Tick += new System.EventHandler(this.check_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 676);
            this.Controls.Add(this.rek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.rek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rek;
        private System.Windows.Forms.Timer check;
    }
}

