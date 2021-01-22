using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathSimulator.Logics;
using MathSimulator.Logics.SoloLearn;

namespace MathSimulator
{
    public partial class CalculatorForm : Form
    {
        Calculation cacl;
        public CalculatorForm()
        {
            cacl = new Calculation();
            InitializeComponent();
        }

        private void Close_But_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

      

       

        private void Example_TBox_TextChanged(object sender, EventArgs e)
        {
            Answer_TBox.Text = cacl.Calculate(Example_TBox.Text);
        }
    }
}
