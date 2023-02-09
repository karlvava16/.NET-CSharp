using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Comparer
    {
        private string expression;
        private bool? result = null;

        public string Expression
        {
            get { return expression; }
            set {
                double? firstV = null;
                double? secondV = null;
                string comp = null;
                int i = 0;
                 
                for (int j = i; j < value.Length; j++)
                {
                    if ((value[j] >= '0' && value[j] <= '9') || value[j] == '-' || value[j] == '+')
                    {
                        i = j;
                        for (; j < value.Length; j++)
                        {
                            if (!(value[j] >= '0' && value[j] <= '9') && value[j] != '-' && value[j] != '+')
                            {
                                firstV = Convert.ToDouble(value.Substring(i, j - i));
                                i = j;
                                break;
                            }
                        }
                        break;
                    }
                }
                if (firstV == null)
                {
                    throw new Exception("Can't read first operand");
                }

                Console.WriteLine(firstV);


                for (int j = i; j < value.Length; j++)
                {
                    if (value[j] == '<' || value[j] == '>' || value[j] == '=' || value[j] == '!')
                    {
                        i = j;
                        for (; j < value.Length; j++)
                        {

                            if (value[j] != '<' && value[j] != '>' && value[j] != '=' && value[j] != '!')
                            {
                                comp = value.Substring(i, j - i);
                                i = j;
                                break;
                            }
                        }
                        break;
                    }
                }
                Console.WriteLine("string : {0}", comp);
                if (comp == null)
                {
                    throw new Exception("Can't read operation");
                }




                for (int j = i; j < value.Length; j++)
                {
                    if ((value[j] >= '0' && value[j] <= '9') || value[j] == '-' || value[j] == '+')
                    {
                        i = j;
                        StringBuilder stringBuilder = new StringBuilder("");
                        for (; j < value.Length; j++)
                        {
                            if ((!(value[j] >= '0' && value[j] <= '9') && value[j] != '-' && value[j] != '+') || value.Length - 1 == j)
                            {
                                secondV = Convert.ToInt32(stringBuilder.ToString());
                                i = j;
                                break;
                            }
                            stringBuilder.Append(value[j]);
                        }
                        break;
                    }
                }
                Console.WriteLine(secondV);

                if (secondV == null)
                {
                    throw new Exception("Can't read second operand");
                }

                switch (comp)
                {
                    case "==":
                        if (firstV == secondV)
                            result = true;
                        else
                            result = false;
                        break;

                    case "!=":
                        if (firstV != secondV)
                            result = true;
                        else
                            result = false;
                        break;

                    case ">":
                        if (firstV > secondV)
                            result = true;
                        else
                            result = false;
                        break;

                    case "<":
                        if (firstV < secondV)
                            result = true;
                        else
                            result = false;
                        break;

                    case ">=":
                        if (firstV >= secondV)
                            result = true;
                        else
                            result = false;
                        break;

                    case "<=":
                        if (firstV <= secondV)
                            result = true;
                        else
                            result = false;
                        break;
                    default:
                        throw new Exception("Unaccessable operation");
                }

                expression = value;
            }
        }

        public bool? Result { get { return result; } }

        public Comparer() { }
    }
}
