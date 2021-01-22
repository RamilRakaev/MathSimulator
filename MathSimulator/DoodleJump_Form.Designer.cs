
namespace MathSimulator
{
    partial class DoodleJump_Form
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
            this.Score_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Score_Tbx
            // 
            this.Score_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Score_Tbx.BackColor = System.Drawing.Color.Black;
            this.Score_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_Tbx.ForeColor = System.Drawing.Color.White;
            this.Score_Tbx.Location = new System.Drawing.Point(709, 12);
            this.Score_Tbx.Name = "Score_Tbx";
            this.Score_Tbx.Size = new System.Drawing.Size(79, 24);
            this.Score_Tbx.TabIndex = 1;
            this.Score_Tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Score_Tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyboardPressed);
            this.Score_Tbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyboardUp);
            // 
            // DoodleJump_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Score_Tbx);
            this.DoubleBuffered = true;
            this.Name = "DoodleJump_Form";
            this.Text = "Doodle Jump";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyboardPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyboardUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Score_Tbx;
    }
}