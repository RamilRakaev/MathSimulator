
namespace MathSimulator
{
    partial class FlappyBird_Form
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
            this.Flappy_Tmr = new System.Windows.Forms.Timer(this.components);
            this.Force_Btn = new System.Windows.Forms.Button();
            this.Score_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Flappy_Tmr
            // 
            this.Flappy_Tmr.Interval = 1;
            // 
            // Force_Btn
            // 
            this.Force_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Force_Btn.Location = new System.Drawing.Point(1, 331);
            this.Force_Btn.Name = "Force_Btn";
            this.Force_Btn.Size = new System.Drawing.Size(122, 53);
            this.Force_Btn.TabIndex = 0;
            this.Force_Btn.Text = "Force";
            this.Force_Btn.UseVisualStyleBackColor = true;
            this.Force_Btn.Click += new System.EventHandler(this.Force_Btn_Click);
            // 
            // Score_Lbl
            // 
            this.Score_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Score_Lbl.AutoSize = true;
            this.Score_Lbl.Location = new System.Drawing.Point(768, 9);
            this.Score_Lbl.Name = "Score_Lbl";
            this.Score_Lbl.Size = new System.Drawing.Size(16, 17);
            this.Score_Lbl.TabIndex = 1;
            this.Score_Lbl.Text = "0";
            // 
            // FlappyBird_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MathSimulator.Resource.flappy_bird;
            this.ClientSize = new System.Drawing.Size(796, 385);
            this.Controls.Add(this.Score_Lbl);
            this.Controls.Add(this.Force_Btn);
            this.DoubleBuffered = true;
            this.Name = "FlappyBird_Form";
            this.Text = "FlappyBirds_Form";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FlappyBird_Form_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Flappy_Tmr;
        private System.Windows.Forms.Button Force_Btn;
        private System.Windows.Forms.Label Score_Lbl;
    }
}