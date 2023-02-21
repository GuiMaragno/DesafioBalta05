using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta05
{
    public static class ValuesInWords
    {
        public static string GetValuesInWords(string value)
        {
            string real = value.Split(',')[0];
            string coin = value.Split(',')[1];

            string CentsInWords = "";
            int i = 0;

            if (!coin.Substring(0, 1).Equals("1")) 
            {
                if (!coin.Equals("10")) 
                {
                    foreach (char c in coin)
                    {
                        if (i == 0)
                        {
                            CentsInWords += (GetDecimals(c.ToString()) + " e ");
                            i++;
                        } else
                        {
                            CentsInWords += GetUnity(c.ToString());
                        }
                    }
                } else
                {
                    CentsInWords = GetDecimal(coin);
                }
            } else
            {
                CentsInWords = GetDecimal(coin);
            }

            string RealInWords = "";
            i = 0;

            if (real.Length == 1)
            {
                RealInWords = GetUnity(real);
            }

            if (real.Length == 2)
            {
                if (real.Substring(1, 1).Equals("0"))
                {
                    if (real.Substring(0, 1).Equals("1"))
                    {
                        
                        RealInWords = GetDecimal(real);
                    } else
                    {
                        RealInWords = GetDecimals(real.Substring(0, 1));
                    }
                }
                else
                {
                    if (real.Substring(0, 1).Equals("1"))
                    {
                        RealInWords = GetDecimal(real);
                    }
                    else
                    {
                        foreach (char r in real)
                        {
                            if (i == 0)
                            {
                                RealInWords += GetDecimals(r.ToString()) + " e ";
                                i++;
                            }
                            else
                            {
                                RealInWords += GetUnity(r.ToString());
                            }
                        }
                    }
                }
            }

            if (real.Length == 3)
            {
                foreach (char r in real)
                {
                    if ((i % 2) == 0)
                    {
                        if (i == 0)
                        {
                            RealInWords += (GetHundred(r.ToString()));
                            i++;
                        }

                        if (i == 2)
                        {
                            if (!r.Equals("0"))
                            {
                                if (!real.Substring(1, 1).Equals("1")) 
                                {
                                    if (!real.Substring(2, 1).Equals("0") && !real.Substring(1, 1).Equals("0"))
                                    {
                                        RealInWords += " e " + GetUnity(r.ToString());
                                    } else
                                    {
                                        RealInWords += GetUnity(r.ToString());
                                    }
                                } else
                                {
                                    RealInWords += " e " + GetUnity(r.ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        if (i == 1) 
                        {
                            if (!r.Equals("0"))
                            {
                                if (real.Substring(1, 1).Equals("1"))
                                {
                                    RealInWords += " e " + GetDecimal(r.ToString() + real.Substring(2, 1));
                                    i++;
                                }
                                else
                                {
                                    RealInWords += " e " + GetDecimals(r.ToString());
                                    i++;
                                }
                            } else
                            {
                                i++;
                            }
                        }
                    }
                }
            }

            if (real.Length == 1)
            {
                if (real.Substring(0, 1).Equals("1"))
                {
                    RealInWords = "Um";
                }
            }

            if (real.Length == 3)
            {
                if (real.Equals("100"))
                {
                    RealInWords = "Cem";
                }
            }

            if (!CentsInWords.Trim().Equals("e")) 
            {
                if (RealInWords.Equals("Um"))
                {
                    return RealInWords.UpperFirstChar() + " real e " + CentsInWords + " centavos";
                } else
                {
                    return RealInWords.UpperFirstChar() + " reais e " + CentsInWords + " centavos";
                }                
            } else
            {
                if (RealInWords.Equals("Um"))
                {
                    return RealInWords.UpperFirstChar() + " real";
                }
                else
                {
                    return RealInWords.UpperFirstChar() + " reais";
                }
            }
        }

        private static string GetUnity(string unity)
        {
            switch (unity)
            {
                case "0":
                    return "";
                case "1":
                    return "um";
                case "2":
                    return "dois";
                case "3":
                    return "tres";
                case "4":
                    return "quatro";
                case "5":
                    return "cinco";
                case "6":
                    return "seis";
                case "7":
                    return "sete";
                case "8":
                    return "oito";
                case "9":
                    return "nove";
                default:
                    return "";
            }
        }

        private static string GetDecimal(string dec)
        {
            switch (dec)
            {
                case "10":
                    return "dez";
                case "11":
                    return "onze";
                case "12":
                    return "doze";
                case "13":
                    return "treze";
                case "14":
                    return "quatorze";
                case "15":
                    return "quinze";
                case "16":
                    return "dezesseis";
                case "17":
                    return "dezesete";
                case "18":
                    return "dezoito";
                case "19":
                    return "dezenove";
                case "20":
                    return "vinte";
                default:
                    return "";
            }
        }

        private static string GetDecimals(string dec)
        {
            switch (dec)
            {
                case "2":
                    return "vinte";
                case "3":
                    return "trinta";
                case "4":
                    return "quarenta";
                case "5":
                    return "cinquenta";
                case "6":
                    return "sessenta";
                case "7":
                    return "setenta";
                case "8":
                    return "oitenta";
                case "9":
                    return "noventa";
                default:
                    return "";
            }
        }

        private static string GetHundred(string hundred)
        {
            switch (hundred)
            {
                case "1":
                    return "cento";
                case "2":
                    return "duzentos";
                case "3":
                    return "trezentos";
                case "4":
                    return "quatrocentos";
                case "5":
                    return "quinhentos";
                case "6":
                    return "seicentos";
                case "7":
                    return "setecentos";
                case "8":
                    return "oitocentos";
                case "9":
                    return "novecentos";
                default:
                    return "";
            }
        }

        private static string UpperFirstChar(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
