using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSimulator
{
    public partial class MainForm : Form
    {
        List<RadioButton> Radio_Answers;
        public MainForm()
        {
            InitializeComponent();
            Collapse_Panels();
            //Radio_Answers = new List<RadioButton>() { answer1, answer2,answer3, answer4, answer5 };
        }
        //int QuantatyTerms = 2;
        //int UpperBorder = 100;
        //int BottomBorder = -100;
        //string Sign = "+";
        //List<int> Terms = new List<int>();
        //Random rand = new Random();


        //int Right=0;
        //private void Randomize()
        //{
        //    for (int i = 1; i < QuantatyTerms; i++)
        //    {
        //        Terms.Add(rand.Next(BottomBorder, UpperBorder));
        //    }
        //    Example_TextBox.Text = string.Empty;
        //    for (int j = 0; j < Terms.Count-1; j++)
        //    {
        //        Example_TextBox.Text += Terms[j]+ Sign;
        //    }
        //    Example_TextBox.Text +=Terms[Terms.Count-1].ToString();
        //}

        //private void Answers()
        //{
        //    Radio_Answers[rand.Next(0, 4)]=
        //}

        private void Collapse_Panels()
        {
            Media_Panel.Visible = false;
            PlayList_Panel.Visible = false;
            Tools_Panel.Visible = false;
        }

        private void HidePanels()
        {
            if (Media_Panel.Visible == true)
                Media_Panel.Visible = false;
            if (PlayList_Panel.Visible == true)
                PlayList_Panel.Visible = false;
            if (Tools_Panel.Visible == true)
                Tools_Panel.Visible = false;
        }

        private void ShowPanel(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HidePanels();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region Mathematic
        private void Media_But_Click(object sender, EventArgs e)
        {
            ShowPanel(Media_Panel);
        }

        private void Calculator_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CalculatorForm());

            HidePanels();
        }
        private void MathSimulator_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MathSimulatorForm());

            HidePanels();

        }
        #endregion

        #region PlayList
        private void PlayList_But_Click(object sender, EventArgs e)
        {
            ShowPanel(PlayList_Panel);
        }
        #endregion

        #region Equalizer
        private void Equalizer_But_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());

            HidePanels();
        }

        #endregion

        #region Games
        private void Games_Btn_Click(object sender, EventArgs e)
        {
            ShowPanel(Tools_Panel);
        }

        private void OSU_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OSU_Form());
            HidePanels();
        }

        private void FlappyBird_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FlappyBird_Form());
            HidePanels();
        }

        private void DoodleJump_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoodleJump_Form());
            HidePanels();
        }
        #endregion

        private Form ActiveForm = null;

        private void OpenChildForm(Form childForm) 
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildForm_Panel.Controls.Add(childForm);
            ChildForm_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        
    }
}
