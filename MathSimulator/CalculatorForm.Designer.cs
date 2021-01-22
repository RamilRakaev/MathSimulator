namespace MathSimulator
{
    partial class CalculatorForm
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
            this.Close_But = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Example_TBox = new System.Windows.Forms.TextBox();
            this.Example_Lbl = new System.Windows.Forms.Label();
            this.Answer_TBox = new System.Windows.Forms.TextBox();
            this.Answer_Lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_But
            // 
            this.Close_But.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close_But.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Close_But.Location = new System.Drawing.Point(13, 20);
            this.Close_But.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_But.Name = "Close_But";
            this.Close_But.Size = new System.Drawing.Size(78, 23);
            this.Close_But.TabIndex = 9;
            this.Close_But.Text = "Close";
            this.Close_But.UseVisualStyleBackColor = false;
            this.Close_But.Click += new System.EventHandler(this.Close_But_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Example_TBox);
            this.panel1.Controls.Add(this.Example_Lbl);
            this.panel1.Controls.Add(this.Answer_TBox);
            this.panel1.Controls.Add(this.Answer_Lbl);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(100, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(300, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 307);
            this.panel1.TabIndex = 14;
            // 
            // Example_TBox
            // 
            this.Example_TBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Example_TBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Example_TBox.Location = new System.Drawing.Point(0, 71);
            this.Example_TBox.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.Example_TBox.Multiline = true;
            this.Example_TBox.Name = "Example_TBox";
            this.Example_TBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Example_TBox.Size = new System.Drawing.Size(604, 43);
            this.Example_TBox.TabIndex = 18;
            // 
            // Example_Lbl
            // 
            this.Example_Lbl.AutoSize = true;
            this.Example_Lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Example_Lbl.ForeColor = System.Drawing.Color.White;
            this.Example_Lbl.Location = new System.Drawing.Point(0, 57);
            this.Example_Lbl.Name = "Example_Lbl";
            this.Example_Lbl.Size = new System.Drawing.Size(63, 14);
            this.Example_Lbl.TabIndex = 21;
            this.Example_Lbl.Text = "Пример:";
            // 
            // Answer_TBox
            // 
            this.Answer_TBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Answer_TBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Answer_TBox.Location = new System.Drawing.Point(0, 14);
            this.Answer_TBox.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.Answer_TBox.Multiline = true;
            this.Answer_TBox.Name = "Answer_TBox";
            this.Answer_TBox.Size = new System.Drawing.Size(604, 43);
            this.Answer_TBox.TabIndex = 19;
            // 
            // Answer_Lbl
            // 
            this.Answer_Lbl.AutoSize = true;
            this.Answer_Lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Answer_Lbl.ForeColor = System.Drawing.Color.White;
            this.Answer_Lbl.Location = new System.Drawing.Point(0, 0);
            this.Answer_Lbl.Name = "Answer_Lbl";
            this.Answer_Lbl.Size = new System.Drawing.Size(55, 14);
            this.Answer_Lbl.TabIndex = 20;
            this.Answer_Lbl.Text = "Ответ:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Close_But);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.MinimumSize = new System.Drawing.Size(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 54);
            this.panel2.TabIndex = 15;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(796, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close_But;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Example_TBox;
        private System.Windows.Forms.Label Example_Lbl;
        private System.Windows.Forms.TextBox Answer_TBox;
        private System.Windows.Forms.Label Answer_Lbl;
    }
}