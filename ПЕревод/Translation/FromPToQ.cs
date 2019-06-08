using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation
{
    public class TranslateFromPToQ 
    {

        private static string digits = "0123456789ABCDEFGHIJKLMNOPQRSTU";

        private static bool isFraction = false;

        private static string intPart = null; 
         
        private static string fractPart = null;
         

        public static string FromPToQ(string N, int P, int Q)
        { 
            SplitNumber(N);
             
            if (isFraction)  
                return IntFromPToQ(intPart, P, Q) + "," + fractFormPToQ(fractPart, P, Q);

            return IntFromPToQ(intPart, P, Q); 
        } 
          
           
        private static void SplitNumber(string N) 
        {
            string[] S = N.Split(',');
            intPart = S[0]; 
            if (S.Length == 2) 
            {  
                fractPart = S[1];
                isFraction = true;
            } 
        } 

        private static string fractFormPToQ(string N, int P, int Q)
        {
            if (P == 10 && Q == 10)
            {
                return N;
            }
            if (P == 10)
            {
                return fractFrom10ToQ(N, Q);
            }
            if (Q == 10) 
            {
                return fractFromPTo10(N, P);
            }
             
            string NumberIn10 = fractFromPTo10(N, P);

            return fractFrom10ToQ(NumberIn10, Q);
        }

        private static string IntFromPToQ(string N, int P, int Q)
        {
            if (P == 10 && Q == 10)
            {
                return N;  
            }
            if (P == 10) 
            { 
                return IntFrom10ToQ(N, Q); 
            }     
            if (Q == 10)
            {
                return IntFromPto10(N, P); 
            }

            string NumberIn10 = IntFromPto10(N, P);

            return IntFrom10ToQ(NumberIn10, Q); 

        }   
          
        /// <summary> 
        /// Перевод целой части числа из 10-ной в Q
        /// </summary>
        /// <param name="N">Число</param> 
        /// <param name="Q">Новая система счисления</param> 
        /// <returns>Число</returns>
        private static string IntFrom10ToQ(string N, int Q)
        {
            string backRes = null;
            int ostatok;
            int Number = int.Parse(N);
            int s = 25;
            while (Number != 0 && s != 0)
            { 
                ostatok = Number % Q;
                Number = Number / Q;
                backRes = backRes + digits[ostatok];
                s--;
            }
            if (string.IsNullOrEmpty(backRes))
                backRes = N;
            string Result = new string(backRes.ToCharArray().Reverse().ToArray());
            return Result;
        }
        /// <summary>
        /// Перевод целой части числа из P в 10-ную 
        /// </summary>
        /// <param name="N">Число</param>
        /// <param name="P">Старая система счисления</param>
        /// <returns>Число</returns>
        private static string IntFromPto10(string N, int P)
        {
            int Count, Res = 0;
            char[] Num = N.ToCharArray();
            int size = Num.Count();
            int j = size - 1;
            for (int i = 0; i < size; i++)
            {
                Count = digits.IndexOf(Num[i]);
                Res = Res + Count * (int)Math.Pow(P, j);
                j--;
            }
            return Res.ToString();
        }
        /// <summary>
        /// Перевод дробной части числа из 10-ной в Q
        /// </summary>
        /// <param name="N">Число</param>
        /// <param name="Q">Новая система счисления</param>
        /// <returns>Число</returns>
        private static string fractFrom10ToQ(string N, int Q)
        {
            int size = N.Length;
            string Res = null;
            int ostatok;
            long Number = long.Parse(N);
            int s = 10; 
            while (Number != 0 && s != 0)
            {
                Number = Number * Q;
                ostatok = (int)(Number / Math.Pow(10, size));
                Res = Res + digits[ostatok];
                Number = Number - ostatok * (int)Math.Pow(10, size);
                s--;
            }
            return Res;
        }
        /// <summary>
        /// Перевод дробной части числа из P в 10-ную 
        /// </summary>
        /// <param name="N">Число</param>
        /// <param name="P">Старая система счисления</param>
        /// <returns>Число</returns>
        private static string fractFromPTo10(string N, int P)
        {
            int Count;
            double Res = 0;
            char[] Num = N.ToString().ToCharArray();
            int size = Num.Count();
            for (int i = 0; i < size; i++)
            {
                Count = digits.IndexOf(Num[i].ToString());
                Res = Math.Round(Res + Count * Math.Pow(P, -(i + 1)), 8);
            }
            string Result = Res.ToString().Remove(0, 2);
            return Result;
        }
    } 
}
