using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSimulator.Logics
{
    public class MathSimulator
    {

        int Min { get; set; }
        int Max { get; set; }
        double Num1 { get; set; }
        double Num2 { get; set; }
        char Act { get; set; }
        int round = 1;
        public int Round
        {
            get { return round; }
            set { if (round <= 28) round = value; else round = 28; }
        }

        char[] Operations = { '-', '+', '/', '*', '%' };
        bool Error;
        public double Answer { get; set; }
        public MathSimulator(string _num1, string _num2, bool _divingByModule = false)
        {
            try
            {
                Min = Convert.ToInt32(_num1);
                Max = Convert.ToInt32(_num2);
                Random rand = new Random();
                if (_divingByModule)
                {
                    Act = Operations[rand.Next(0, 5)];
                }
                else
                {
                    Act = Operations[rand.Next(0, 4)];
                }

                Num1 = rand.Next(Min, Max);
                Num2 = rand.Next(Min, Max);
            }
            catch (Exception e)
            {
                Error = true;
            }
        }

        public string OutputExample()
        {
            if (!Error)
                return Num1 + " " + Act + " " + Num2;
            else
                return "";
        }

        public bool CheckAnswer(string _answer)
        {
            if (!Error)
            {
                switch (Act)
                {
                    case '-':
                        Answer = Num1 - Num2;
                        break;
                    case '+':
                        Answer = Num1 + Num2;
                        break;
                    case '*':
                        Answer = Num1 * Num2;
                        break;
                    case '/':
                        Answer = Num1 / Num2;
                        break;
                    case '%':
                        Answer = Num1 % Num2;
                        break;
                    default:
                        return false;
                }
                Answer = Math.Round(Answer, Round);
                try
                {
                    if (Answer == Convert.ToInt32(_answer))
                    {
                        return true;
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
