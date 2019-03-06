using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Long__
{ 
    /// <summary>
    /// Реализация чисел, больше long
    /// </summary>
    public class BigNumber
    {                                              
        /// <summary> 
        /// Массив цифр
        /// </summary>  
        public int[] digits;
         
        /// <summary> 
        /// Знак числа True - плюс False - минус  
        /// </summary>
        public bool sign;

        /// <summary>
        /// Длина числа 
        /// </summary>
        private int Length; 

        public BigNumber(string value)
        {
            sign = true;

            if (value[0] == '-')  
            {
                throw new Exception("Нельзя вводить отрицательные числа");
            } 

            digits = new int[value.Length]; 
             
            if (digits.Length - 1 == '0')
            {
                throw new Exception("Число не может начинаться с нуля");
            }

            for (int i = value.Length - 1; i >= 0; i--) //из строки с конца ебашим в байт массив 
            {
                char c = value[value.Length - i - 1]; 
                digits[i] = int.Parse(c.ToString()) ;
            }
                
            Length = digits.Length;  
        }
         
        /// <summary>
        /// Альтернативный конструктор, сразу с массивом, минуя предыдущий этап 
        /// </summary>
        /// <param name="digits">Байтовый массив</param>
        private BigNumber(int[] digits) 
        {
            sign = true;  
              
            this.digits = digits; 
             
            Length = digits.Length; 
        } 

        public static bool operator >(BigNumber a1, BigNumber a2)
        {
            if (a1.Length != a2.Length)
                return a1.Length > a2.Length;
            for (int i = a1.Length - 1; i >= 0; i--)
            {
                if (a1.digits[i] != a2.digits[i])
                    return a1.digits[i] > a2.digits[i];
            }
            return false;
        }

        public static bool operator >=(BigNumber a1, BigNumber a2)
        {
            if (a1.Length != a2.Length)
                return a1.Length > a2.Length; 
            for (int i = a1.Length - 1; i >= 0; i--) 
            {
                if (a1.digits[i] != a2.digits[i]) 
                    return a1.digits[i] > a2.digits[i];
            } 
            return true; 
        }

        public static bool operator <=(BigNumber a1, BigNumber a2)
        {
            if (a1.Length != a2.Length)
                return a1.Length < a2.Length;
            for (int i = a1.Length - 1; i >= 0; i--)
            {
                if (a1.digits[i] != a2.digits[i])
                    return a1.digits[i] < a2.digits[i];
            }
            return true; 
        }


        public static bool operator <(BigNumber a1, BigNumber a2)
        {
            if (a1.Length != a2.Length)
                return a1.Length < a2.Length;
            for (int i = a1.Length - 1; i >= 0; i--)
            {
                if (a1.digits[i] != a2.digits[i]) 
                    return a1.digits[i] < a2.digits[i];
            }
            return false;
        }

        public static BigNumber operator +(BigNumber a1, BigNumber a2)
        {
            int tempArrLength = Math.Max(a1.digits.Length, a2.digits.Length); // "Временная длина массива" - выбираем длину наиб числа 
            int[] tempArr = new int[tempArrLength]; // Временный массив временной длины, для результата сложения 

            int overflow = 0; // если при сложении максимальный разряд увеличится 

            for (int i = 0; i < tempArr.Length; i++)
            {
                int result = overflow;

                if (a1.digits.Length > i) result += a1.digits[i]; //записываем одну цифру в резалт
                if (a2.digits.Length > i) result += a2.digits[i]; //прибавляем к ней 2ую
                if (result > 9) // если больше двух цифр . Например 14
                {
                    // оставляем меньший разряд. Пример: 4 = 14 - 10
                    result -= 10;
                    overflow = 1;
                }
                else // иначе result = result
                {
                    overflow = 0;
                }
                tempArr[i] = result; // записываем результат в массив
            }
            if (overflow > 0) // если больше двух цифр, увеличиваем массив , добавляя единицу в больший разряд Пример: 14 - 1 в десятки 
            {
                Array.Resize(ref tempArr, tempArr.Length + 1);
                tempArr[tempArr.Length - 1] = 1;
            }

            return new BigNumber(tempArr);
        } 


        public static BigNumber operator -(BigNumber a1, BigNumber a2)
        {
            int tempArrLength = Math.Max(a1.digits.Length, a2.digits.Length); // "Временная длина массива" - выбираем длину наиб числа 
            //int[] tempArr = new int[tempArrLength]; // Временный массив временной длины, для результата сложения 
            List<int> tempList = new List<int>(); 

            int perenos = 0; // перенос
                
            BigNumber NegativeResult; 

            if (a1 < a2) 
            {
                NegativeResult = a2 - a1; 
                NegativeResult.sign = false;

                return NegativeResult;  
            }  

            for (int i = 0; i < tempArrLength; i++)
            {
                int result = 0;  
                if (perenos == 1)
                    a1.digits[i] = Convert.ToInt32(a1.digits[i] - 1);
                if (a1.digits.Length > i) result += a1.digits[i]; //записываем одну цифру в резалт
                if (a2.digits.Length > i) result -= a2.digits[i]; //вычитаем 
                if (result < 0) // 
                {
                    //
                    result += 10;
                    perenos = 1;
                }
                else // иначе result = result
                { 
                    perenos = 0;
                }
                tempList.Add(Convert.ToInt32(result)); // записываем результат в массив
                 
            }   
             
            return new BigNumber(NullCheckFunc(tempList));
                       
        }
            
        /// <summary>
        /// Удаление нулей впереди  
        /// </summary>
        /// <param name="result"></param>
        private static int[] NullCheckFunc(List<int> result)
        {
            for (int i = result.Count() - 1; i >= 0; i--)
            {
                if (result[i] == 0 && i == result.Count()-1 && result.Count() != 1)
                {
                    result.RemoveAt(i);
                    
                }
                else
                {  
                    break;
                } 
            }

            return result.ToArray();  
        }


        public static BigNumber operator *(BigNumber a1, BigNumber a2)
        {
            List<int> tempresult = new List<int>();
            BigNumber finalresult = new BigNumber("0");
            int overflow = 0;//переменная для перебора   
            for (int j = 0; j < a2.Length; j++) //проход по второму числу(с конца)
            {
                tempresult.Clear();//Очищаем лист
                if (j != 0) //если не первое число , до добавляем нули по количеству проходов
                {
                    for (int z = 0; z < j; z++)
                    {
                        tempresult.Add(0);
                    }

                }
                for (int i = 0; i < a1.Length; i++)//Проход по первому числу (с конца)
                {
                    int result1 = 0;

                    if (a1.digits.Length > j) result1 += a1.digits[i];//записываем одну цифру в резалт
                    if (a2.digits.Length > j) result1 *= a2.digits[j];//перемножаем
                    if (overflow > 0) result1 += overflow;//если есть перебор с пердыдушего шага то прибавляем к резалту

                    if (result1 > 9)//Если результат больше 2х цифор
                    {
                        tempresult.Add(result1 % 10);//заносим остаток от деление на 10 например 81 % 10 = 1
                        overflow = result1 / 10;//заносим результат от деление на 10 например 81 / 10 = 8 (так как тип int целочисленный)

                    }
                    else //если резалт меньше 2х чисел
                    {
                        tempresult.Add(result1);
                        overflow = 0;
                    }
                    if (!(i < a1.Length - 1) && overflow > 0)//Если не последний шаг цикла
                    {
                        tempresult.Add(overflow);
                        overflow = 0;
                    }

                }
                BigNumber newnumber = new BigNumber(tempresult.ToArray());//делаем новое "BigNumber" и заносим туда данные с листа
                finalresult += newnumber;//складываем "BigNumber"

            }
            return finalresult;
             
        }



        public static BigNumber operator /(BigNumber A, int B)
        {
            int carry = 0;
             
            //List<int> res = new List<int>();
               
            for (int i = A.Length - 1; i >= 0; --i) 
            { 
                long current = A.digits[i] + carry * 10;
                A.digits[i] = Convert.ToInt32(current / B);
                carry = Convert.ToInt32(current % B);  
            }


            A.digits = NullCheckFunc( A.digits.ToList() ); 
             
             //return new BigNumber( res.ToArray() );   
              
            return A;  
             
          
        }   

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(digits.Length);
            for (int i = digits.Length - 1; i >= 0; i--)//Чем младше индекс - тем меньше цифра
            {
                sb.Append(digits[i].ToString());
            }

            if (sign == false) 
                sb.Insert(0, "-"); 

            return sb.ToString();
        }

    } 
}


    
