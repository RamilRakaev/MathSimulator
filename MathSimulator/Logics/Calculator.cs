using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSimulator.Logics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    namespace SoloLearn
    {
        class Calculation
        {
            char[] Operations = new char[] { '*', '/', '%', '+', '-' };

            /// <summary>
            /// Решает примеры и отлавливает ошибки
            /// </summary>
            /// <param name="_example"></param>
            /// <returns></returns>
            public string Calculate(string _example)
            {
                try
                {
                    return CalculateWithBrackets(_example);
                }
                catch (Exception ex)
                {
                    return ex.Message.ToString();
                }
            }

            /// <summary>
            /// Решает пример со скобками
            /// </summary>
            /// <param name="_example"></param>
            /// <param name="_exList"></param>
            /// <returns></returns>
            public string CalculateWithBrackets(string _example = null, List<char> _exList = null)
            {
            again:
                if (_example.Contains('('))
                {
                    int start = _example.LastIndexOf('(');
                    int length;
                    for (length = 1 + start; true; length++)
                    {
                        if (_example[length] == ')')
                        {
                            //_example.Remove(start, length - start + 1);
                            length = length - start + 1;
                            //_example.Insert(start, "1");
                            string answer = CalculateWithoutBrackets(_example.Substring(start + 1, length - 2));
                            _example = _example.Replace(_example.Substring(start, length), answer);
                            goto again;
                        }

                    }

                }
                return CalculateWithoutBrackets(_example);
            }


            /// <summary>
            /// Решает пример без скобок
            /// </summary>
            /// <param name="subExample"></param>
            /// <returns></returns>
            public string CalculateWithoutBrackets(string subExample)
            {
                List<char> acts = ReturnActs(subExample);

                List<string> numbers = subExample.Split(Operations, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (subExample[0] == '-')
                {
                    numbers[0] = '-' + numbers[0];
                }
                for (byte j = 1; j < 3; j++)
                {
                    int num = 0;
                    foreach (char act in acts)
                    {
                        if (numbers.Count == 1)
                            return numbers[0];
                        string value = TwoNum(j, numbers[num], act, numbers[num + 1]);
                        if (value != "n")
                        {
                            numbers.RemoveAt(num);
                            numbers.RemoveAt(num);
                            numbers.Insert(num, value);
                        }
                        else
                        {
                            num++;
                        }
                    }
                    CleanActs(ref acts);
                }
                if (numbers.Count == 1)
                    return numbers[0];
                return "0";
            }
            /// <summary>
            /// Решает пример из двух чисел
            /// </summary>
            /// <param name="priority">Уровень приоритета</param>
            /// <param name="num1"></param>
            /// <param name="act">арифметическая операция</param>
            /// <param name="num2"></param>
            /// <returns></returns>
            string TwoNum(byte priority, string num1, char act, string num2)
            {
                if (priority == 1)
                    switch (act)
                    {
                        case '*':
                            return Convert.ToString(Convert.ToInt64(num1) * Convert.ToInt64(num2));
                        case '/':
                            return Convert.ToString(Convert.ToInt64(num1) / Convert.ToInt64(num2));
                        case '%':
                            return Convert.ToString(Convert.ToInt64(num1) % Convert.ToInt64(num2));
                        default:
                            return "n";
                    }
                else
                    switch (act)
                    {
                        case '+':
                            return Convert.ToString(Convert.ToInt64(num1) + Convert.ToInt64(num2));
                        case '-':
                            return Convert.ToString(Convert.ToInt64(num1) - Convert.ToInt64(num2));
                        default:
                            return "n";
                    }
            }

            /// <summary>
            /// Возвращает все арифметические операции из примера
            /// </summary>
            /// <param name="_subExample">пример</param>
            /// <returns>Массив символов</returns>
            List<char> ReturnActs(string _subExample)
            {
                List<char> acts = new List<char>();
                for (int i = 0; i < _subExample.Length; i++)
                {
                    foreach (char act in Operations)
                    {

                        if (_subExample[i] == act)
                        {
                            if (i != 0)
                                acts.Add(_subExample[i]);
                        }
                    }
                }
                return acts;
            }

            /// <summary>
            /// Удалаяет все арифметические операции с высоким уровнем приоритета
            /// </summary>
            /// <param name="_acts">арифметические операции</param>
            void CleanActs(ref List<char> _acts)
            {
                for (int i = 0; i < _acts.Count;)
                {
                    if (_acts[i] == '*' | _acts[i] == '/' | _acts[i] == '%')
                    {
                        _acts.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
        
    }

    
}

