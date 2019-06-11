using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation
{
    public class TranslateFromPToQ 
    {
        /// <summary>
        /// Основания 
        /// </summary>
        private static string digits = "0123456789ABCDEFGHIJKLMNOPQRSTU";

        /// <summary>
        /// Является ли дробью
        /// </summary> 
        private static bool isFraction = false;

        /// <summary>
        /// Целая часть
        /// </summary>
        private static string intPart = null; 
         

        /// <summary>
        /// Дробная часть 
        /// </summary>
        private static string fractPart = null;
         
        /// <summary>
        /// Перевод из системы счисления P в СС Q
        /// </summary>
        /// <param name="N">Число для перевода</param> 
        /// <param name="P">Исходная система счисления</param>
        /// <param name="Q">Конечная система счисления</param>
        /// <returns></returns>
        public static string FromPToQ(string N, int P, int Q)
        { 
            SplitNumber(N); // делим входные данные на целую и дробную часть 
             
            if (isFraction)  // если это дробь, переводим сначала целую, затем дробную часть 
                return IntFromPToQ(intPart, P, Q) + "," + fractFormPToQ(fractPart, P, Q);

            return IntFromPToQ(intPart, P, Q); 
        }

         
        /// <summary>
        /// Деление входные данные на целую и дробную часть 
        /// </summary>
        /// <param name="N"></param>
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

        /// <summary>
        /// Перевод дробной части из системы счисления P в СС Q
        /// </summary>
        /// <param name="N"></param>
        /// <param name="P"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Перевод целой части из системы счисления P в СС Q
        /// </summary>
        /// <param name="N"></param> 
        /// <param name="P"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
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

        //Целая часть переводится из десятичной системы счисления в другую систему счисления с помощью последовательного 
        //деления целой части числа на основание системы счисления до получения целого остатка, 
        //меньшего основания системы счисления.
        //Результатом перевода будет являться запись из остатков, начиная с последнего.

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


        //Для перевода числа из любой системы счисления в десятичную достаточно пронумеровать его разряды, 
        //начиная с нулевого(разряд слева от десятичной точки) аналогично примерам 1 или 2. 
        //Найдём сумму произведений цифр числа на основание системы счисления в степени позиции этой цифры

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
