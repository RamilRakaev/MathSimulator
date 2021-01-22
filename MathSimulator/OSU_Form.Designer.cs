
namespace MathSimulator
{
    partial class OSU_Form
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Scope_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Scope_Lbl
            // 
            this.Scope_Lbl.AutoSize = true;
            this.Scope_Lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.Scope_Lbl.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Scope_Lbl.Location = new System.Drawing.Point(778, 0);
            this.Scope_Lbl.Name = "Scope_Lbl";
            this.Scope_Lbl.Size = new System.Drawing.Size(18, 17);
            this.Scope_Lbl.TabIndex = 0;
            this.Scope_Lbl.Text = "0";
            // 
            // OSU_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MathSimulator.Resource.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 385);
            this.Controls.Add(this.Scope_Lbl);
            this.Name = "OSU_Form";
            this.Text = "OSU";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OSU_Form_Paint);
            this.Resize += new System.EventHandler(this.OSU_Form_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Scope_Lbl;
    }
}