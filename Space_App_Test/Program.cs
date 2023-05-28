using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace Space_App_Test
{
    internal class Program
    {
        static int Sum(int a, int b) => a + b;
        static int Sum(int n)
        {
            int x;
            int result = 0;
            for (int i = 0; i < n; i++)
            {

                x = Int32.Parse(Console.ReadLine());
                result += x;
            }
            return result;
        }
        static int Sum_3(int n)
        {
            int x = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {

                x = Int32.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    result += x;
                }
                else { result -= x; }
            }
            return result;
        }
        static string Leap_year(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)

            {
                return "1";
            }
            else return "0";
        }
        static int firstMin(int n)
        {


            int minIndex = 0;
            int min = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {



                int x = Int32.Parse(Console.ReadLine());

                if (x < min)
                {
                    minIndex = i;
                    min = x;

                }




            }
            return minIndex;
        }

        static int Binary(int n)
        {
            string str = "";
            int cnt = 0;
            if (n == 1)
            {
                return 0;
            }
            else
            {
                while (n > 0)
                {

                    if (n % 2 == 0)
                    {
                        str += "0";
                    }
                    else { str += "1"; }
                    n /= 2;
                }

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '0')
                    {
                        cnt++;
                    }
                    if (str[i + 1] == '1')
                    {
                        break;
                    }
                }
                return cnt;
            }
        }

        static string Baden(int cm)
        {
            int ft = cm / 36;
            int dm = (cm % 36) / 3;
            if (((cm % 36) % 3) > 1)
                dm++;
            string str = Convert.ToString(ft);
            str += " "; str += Convert.ToString(dm);
            return str;
        }
        static void Max_Gryz(int n, int MaxW)
        {
            int cnt = 0;
            int MaxWeight = 0;
            int[] j = new int[n];
            for (int i = 0; i < n; i++)
            {
                j[i] = Convert.ToInt32(Console.ReadLine());
                if (MaxWeight + j[i] < MaxW)
                {
                    MaxWeight += j[i];
                    cnt++;
                }
            }
            Console.WriteLine(cnt + " " + MaxWeight);
        }

        static void Evklid(int a, int b)
        {

            int nod;
            int cnt = 0;
            while (b != a)
            {
                cnt++;
                if (b > a)
                {
                    b = b - a;

                }
                else
                {
                    a = a - b;

                }

            }
            cnt++;
            nod = b;
            Console.WriteLine(nod + " " + cnt);
        }

        static void Student(int Age)
        {
            if (Age > 0)
            {
                if (Age < 7) { Console.WriteLine("Rebenok"); }
                if (Age > 22) { Console.WriteLine("Specialist"); }
                if (Age >= 7 && Age <= 17) { Console.WriteLine($"Schoolchild {Age - 6}"); }
                if (Age >= 18 && Age <= 22) { Console.WriteLine($"Student {Age - 17}"); }
            }
            else { Console.WriteLine("Nedopystimoe chislo"); }
        }

        static void Quadro(int a1,int b1,int a2,int b2)
        {
            int min1, max1, min2, max2;
            min1=a1<b1 ? a1 : b1;
            max1 = a1 > b1 ? a1 : b1;
            min2= a2 < b2 ? a2 : b2;
            max2= a2 > b2 ? a2 : b2;
            if (min1 + min2 == max1 && max1 == max2)
            { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }

        static int MinCnt(int n)
        {
            int[] arr=new int[n];
            int min;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            min = arr.Min();
            for (int i = 0; i < n; i++)
            {
                if (min == arr[i])
                {
                    cnt++; 
                }
            }
            return cnt;
        }

        static bool Easy_check(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                { return false; }
            }
            return true;
            
        }

        static void Easy(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (Easy_check(i))
                {
                    Console.Write(i+" ");
                    
                }
            }
        }

        static void quadratic(int a,int b,int c)
        {
            double d=Math.Pow(b,2)-4*a*c;
            
            if (d > 0)
            {
                Console.WriteLine("2");
            }
            if (d == 0)
            {
                 Console.WriteLine("1");
            }
                    if (d < 0)
                    {
                        Console.WriteLine("0");
                    }
        }

       static int max = 0;
        static int NKD(int a)
        {

            int cnt = 0;
            for (int i = a; i >0; i--)
            {
                if (a%i==0)
                {
                    cnt++;
                   
                    
                }
                
            }
            
           
            return cnt;
        }

        static void NKD_2(int a, int b)
        {
            int cnt = 0;
            bool isfirst = true;
            for (int i = a; i <= b; i++)
            {
                max = max > NKD(i) ? max : NKD(i);
            }
            for (int i = a; i <= b; i++)
            {
                if (NKD(i)==max)
                {
                    cnt++;

                } 
            }
            Console.WriteLine(cnt);
            for (int i = a; i <= b; i++)
            {
                if (!isfirst)
                {
                    if (NKD(i) == max)
                    {
                        Console.Write(",{0}", i);
                    }
                }
                else if (isfirst)
                {
                    if (NKD(i)== max)
                    {
                        Console.Write("{0}", i);
                        isfirst = false;
                    }
                }
            }
        }

        static int _2018(int n)
        {
            int[] mas = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine()); 

            }
            for (int i = 0; i < n; i++)
            {
                if (mas[i] < 0)
                {
                    mas[i] *= -1;
                }

            }


            int x=1, y=2;



            for (int i = 0; i < n; i++)
            {

                if (i == 0)                                                     
                {
                    sum += mas[i];
                }
                if (i>=1&&i<=x+1)
                { 
                    sum -= mas[i];
                }
                if (i >= 3 && i <= 5)
                {
                    sum += mas[i];
                }
                if (i >= 6 && i <= 9)
                {
                    
                    sum -= mas[i];
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i]+"  ");

            }
            return sum;
        }    //dodelat

        static void _2019(int n)
        {
            
            int book_CNT=1;
            int book_last = 1;
            for (int i = 1; i <= n; i++)
            {
                if (n > book_last)
                {
                    book_CNT++;
                    book_last += book_CNT;
                }
                else
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static void _2020(int n)
        { 
            int[] mas = new int [n];
            int[] point = new int [n];

            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                point[i] = 1;
            }
            Array.Sort(mas);
          
            for (int i = 1; i < n; i++)
            {
                if (mas[i] % mas[i - 1] == 0 && mas[i] / mas[i - 1] == 1)
                {
                    point[i] = point[i - 1] + 1;
                }
            }
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(point[i] + " ");
            //}
            int number = mas[0];
            int index = point[0];
            for (int i = 0; i < n; i++)
            {
                if (point[i]>index)
                {
                    index=point[i];
                    number = mas[i];
                }
            }
            Console.WriteLine($"Самое частое число:{number}, встречается :{index} раз");


            //Console.WriteLine(number+" ");
        }

        static void _2021(int n)
        {
            int[] mas = new int[n];
           
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int a = 0; a < 2; a++)
            {
                int max = mas[0];
                for (int i = 0; i < n; i++)
                {
                    if (mas[i] > max)
                    {
                        max = mas[i];
                    }
                }


               
                for (int i = 0; i < n; i++)
                {
                    if (mas[i] == max)
                    {
                        mas[i] /= 2;
                    }
                }
                
                Console.WriteLine("\n\n");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }

        static void _2022(int n)
        {
            int cnt = 0;
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    if (mas[i] % mas[j] == 0)
                    {
                        cnt++; 
                    }
                }
            }
            Console.WriteLine(cnt);
        }

        static void _2023(int Size1,int Size2)
        {
            int[] mas1 = new int[Size1];
            int[] mas2 = new int[Size2];
            int min = Size1 < Size2 ? Size1 : Size2;
            List<int> mas3 = new List<int>();
            for (int i = 0; i < Size1; i++)
            {
                Console.Write($"mas1[{i+1}]");
                mas1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Size2; i++)
            {
                Console.Write($"mas2[{i + 1}]");
                mas2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <min; i++)
            {
                if (mas1[i] == mas2[i])
                {
                    mas3.Add(mas1[i]);
                }
            }
            if (mas3.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(mas3.Count);
                foreach (int i in mas3)
                {
                    Console.Write(i + " ");
                }
            }

        }

        static void _2024(int n)
        {
            int[]mas = new int[n];
            int[]mas1 = new int[n/2];
            int[]mas2 = new int[n/2];
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n / 2; i++)
            {
                mas1[i] = mas[i];
            }
            int x = n/2;
            for (int i = 0; i < n/2; i++)
            {
                
                mas2[i] = mas[x];
                x++;
            }
            Console.WriteLine("mas:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("\nmas1:");
            for (int i = 0; i < mas1.Length; i++)
            {
                Console.Write(mas1[i] + " ");
            }
            Array.Reverse(mas2);
            Console.WriteLine("\nmas2:");
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(mas2[i] + " ");
            }
            int cnt = 0;
            for (int i = 0; i < mas1.Length; i++)
            {

                if (mas1[i] != mas2[i])
                {
                   
                    cnt++;
                    
                }
            }
            Console.WriteLine(cnt);
        }

        static void _2025(int n,int m)
        {
            int[]number = new int[m];
            int[] mas = new int[n];
            int minIndex = 0;
            int maxIndex = 0;
            
            for (int i = 0; i <n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0;i<m; i++ )
            {
                minIndex  = Convert.ToInt32(Console.ReadLine());
                maxIndex = Convert.ToInt32(Console.ReadLine());
                int min = mas[minIndex-1];
                for (int j = minIndex-1; j <= maxIndex-1; j++)
                {
                    if (min > mas[j])
                    {
                        min = mas[j];
                    }
                    number[i] = min;
                }
            }
            for (int j =0; j <m; j++)
            {
                Console.Write(number[j] + " ");
            }
        }

        static void _2026(int n)
        {
            int[]mas = new int[n+1];
            int[]mas1 = new int[n+1];
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        mas1[i] = mas[j];
                        break;
                    }
                    
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas1[i]+" ");
            }
        }

        static void _2027(int n)
        {
            int[] mas = new int[n];
            int[] mas2 = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                mas2[i] = mas[i];
            }
            int cnt;
            for (int i = 1; i <= 2; i++)
            {
                if (i == 2)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[j] = mas2[j];
                    }
                }

                int min = Convert.ToInt32(Console.ReadLine()) - 1;
                int max = Convert.ToInt32(Console.ReadLine()) - 1;
                cnt = max;
                for (int j = 0; j < n; j++)
                {
                    if (min <= cnt)
                    {
                        mas2[min] = mas[max];
                        min++;
                        max--;
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas2[i] + " ");
            }


        }

        static void _2028(int n)
        {
            int[]mas = new int[n];
            int[]cnt = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas[j] == i)
                    {
                        cnt[i]++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (cnt[i] > 0)
                {
                    Console.WriteLine($"{i} = {cnt[i]}");
                }
            }

        }

        static void _2029(int n)
        {
            int[] mas = new int[n];
            int cnt = 0;
            int k=0;
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = mas.Min();
            Console.WriteLine($"Min = {min}");
            for (int i = 0; i < n; i++)
            {
                if (mas[i] == min)
                {
                    cnt++;
                }
            }
            cnt /= 2;
            if (cnt % 2 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (mas[i] == min)
                    {
                        k++;
                        if (cnt == k)
                        {
                            Console.WriteLine($" Минимальный средний элемент находится на {i + 1} позиции");
                            break;
                        }
                    }
                }
            }
            else
                for (int i = 0; i < n; i++)
                {
                    if (mas[i] == min)
                    {
                        k++;
                        if (cnt == k)
                        {
                            Console.WriteLine($" Минимальный средний элемент находится на {i + 2} позиции");
                            break;
                        }
                    }
                }
        }

        static void _2030(int n)
        {
            int[]mas  = new int[n];
            int cnt = 0;
            int sum;
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                
                for (int j = i; j < n; j++)
                {
                  
                    sum = 0;
                    for (int num = i; num <= j; num++)
                    {
                        sum += mas[num];
                    }
                    if (sum == 0)
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine($"Пар получилось = {cnt}");
        }

        static void _2031(int n)
        {
            int[]mas = new int[n];
            bool[] uniq = new bool[n];
            int count = 0;
            for (int i = 0;i<n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
                uniq[i] = true;
     
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas[i] == mas[j]&& i!=j)
                    {
                        uniq[i] = false;
                    }
                }
            }
            foreach (bool i in uniq)
            {
                Console.Write(i + " ");
            }
            for (int i = 0; i < n; i++)
            {
                if (i == 0 && !uniq[i])
                {
                    count++;
                }
                else if (!uniq[i] && mas[i] != mas[i - 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);

          
            if (count != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == 0 && !uniq[i])
                    {
                        Console.Write(mas[i]+" ");
                    }
                    else if (!uniq[i] && mas[i] != mas[i - 1])
                    {
                        Console.Write(mas[i]+ " ");
                    }
                }
            }

        }

        static void _2032(int number1,int number2)
        {
            int[] mas1 = new int[number1];
            int[] mas2 = new int[number2];
            string str1 = "";
            int n1;
            int n2;
            for (int i = 0; i < number1; i++)
            {
                mas1[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < number2; i++)
            {
                mas2[i] = Convert.ToInt32(Console.ReadLine());

            }
           
            str1 = String.Join("",mas1);
            n1 = Convert.ToInt32(str1);
            str1 = String.Join("",mas2);
            n2 = Convert.ToInt32(str1);
            if (n1 < n2) { Console.WriteLine(-1); }
            else if(n1 == n2) { Console.WriteLine(0); }
            else  { Console.WriteLine(1); }
            

        }

        static void _2033(int n)
        {
            int[] mas  = new int[n];
            int n1;
            string str = "";
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            n1 = Convert.ToInt32(String.Join("", mas));
            n1 += 1;
            
            str = n1.ToString();
            
            mas = str.Select(x => int.Parse(x.ToString())).ToArray();
            foreach (int i in mas)
            {
                Console.Write(i + " ");
            }
        }

        static void _2035(int n)
        {
            int[] mas = new int[n];
            List<int> list = new List<int>();

            int z = 0;
            int temp = 0;
            int period = 1;
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            int temp1 = 1;
            Console.WriteLine("--------------------------");
            
           
                for (int i = 1; i < n; i++)
                {
                    if (mas[z] == mas[i])
                    {
                        temp = i;
                    if (mas[z + 1] != mas[temp + 1])
                    {
                        temp += 1;
                        
                        break;
                    }
                    break;                         
                    }

                }           
            for (int i = 0; i <temp;i++)
            {
                for (int j = temp; j < n; j++)
                {                   
                        if (mas[i] == mas[j])
                        {
                        list.Add(mas[i]);
                       
                        break;
                        }
                        else
                        {
                        
                        
                       
                    }
                    
                }
            }
          Console.WriteLine(period = n/list.Count);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }


        }

        static void _2036(int n)
        {
            List<string> mas3 = new List<string>();

            

            for (int i = 0; i < n; i++)
            {
                _2036_1();
            }

            foreach (var s in mas3)
            {
                Console.WriteLine(s);
            }
            void _2036_1()
            {
                string mas = "";
                int cnt = 0;
                string str = "";
                
                str = Console.ReadLine();
                char[] charArray = str.ToCharArray();
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray[i] == 'e' || charArray[i] == 'y' || charArray[i] == 'u' || charArray[i] == 'i' || charArray[i] == 'o' || charArray[i] == 'a')
                    {
                        cnt++;
                        if (cnt == 3)
                        {
                            break;
                        }

                    }
                    else
                    {
                        cnt = 0;
                    }

                    charArray = str.ToCharArray();
                }
                if (cnt < 3)
                {
                    mas += new string(charArray);
                    mas3.Add(mas);


                }
            }
           
        }

        static void _2037(int min)
        {
            
            int index = 0 ;
            string[] str;
            str = Console.ReadLine().Split(',');
            StringBuilder list = new StringBuilder(); 
            foreach (string s in str)
            {
                if (s.Length >= min)
                {
                    list.Append(s);
                    list.Append(',');
                }
            }
            if (list.Length > 0)
            {
                list.Remove(list.Length - 1, 1);
            }

            Console.Write(list);


        }

        static void _2038()
        {
            string input;
            string[] words;
            int max;

            input = Console.ReadLine();
            input = Regex.Replace(input, @"[^a-zA-Z]", " ");
           
            words = input.Split();
            max = words[0].Length;
            Console.WriteLine(input);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    
                    max = words[i].Length;
                }
            }
            Console.WriteLine(max);
        }

        static void _2039()
        {
            string input;
            string[] words;
            int cnt = 0;//лишние \n
            input = Console.ReadLine();
            input = Regex.Replace(input,@"[^a-zA-z]"," ");
            words=input.Split(' ');
            
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "")
                {
                    cnt++;
                }
            }

            Console.WriteLine(words.Length);
            
        }

        static string _2040()
        {
            string s = Console.ReadLine();
            s += s;
            int n = s.Length;
            int i = 0, ans = 0;
            while (i < n / 2)
            {
                ans = i;
                int j = i + 1, k = i;
                while (j < n && s[k] <= s[j])
                {
                    if (s[k] < s[j])
                        k = i;
                    else
                        k++;
                    j++;
                }
                while (i <= k) i += j - k;
            }
            return s.Substring(ans, n / 2);
        }

        static void _2041()
        {
            string str = Console.ReadLine();
            int n = str.Length;
            string test="";
            bool isTrue = false;          
            int right = str.Length - 1;
            int left = 0;
            int x = 1;
            int y = 0;
            while (y<str.Length)
            {
                if (str[left] == str[right])
                {
                    test += str[left];
                    right--;
                    left++;
                }
                else
                {
                   
                    right = str.Length - x;
                    x++;
                    left = 0;
                }
                y++;
                
            }
            for (int i = 0; i < n / 2; i++)
            {
                if (str[i] == test[i])
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
            }

            if (isTrue)
            {
                Console.WriteLine("YES");
            }
            else { Console.WriteLine("NO"); }

        }

        static void _2042()
        {
            List<int> list = new List<int>();
            string str = Console.ReadLine();
            string pod_str = Console.ReadLine();
            pod_str = pod_str.Replace('?','.');
            Regex regex = new Regex(pod_str);
            MatchCollection matches;
            matches = regex.Matches(str);
            for (int i = 0; i < str.Length; i++)
            {
                matches = regex.Matches(str, i);
                if (matches.Count > 0)
                {
                    for (int k = 0; k < matches.Count; k++)
                    {
                        list.Add(matches[k].Index + 1);
                        break;
                    }
                }
            }
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                pipa();
            }
            
            for (int k = 0; k < list.Count; k++)
            {    if (list[k] != 0)
                {
                    Console.Write(list[k] + " ");
                }
            }

            void pipa()
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] == list[i - 1])
                    {
                        list.RemoveAt(i);
                    }
                }
            }
        }

        static void _2043()
        {
            string str = Console.ReadLine();
            StringBuilder main = new StringBuilder();
            StringBuilder copy = new StringBuilder();
            main.Append(str);
            int j = 1;
            for (int i = 0; i < main.Length; i++)
            {
                copy.Append(main[i]);
                if(main[i]=='>'&&i<main.Length-2&&main[i+2]!='/')
                {
                    copy.Append("\n");
                    copy.Append(' ', 2 * j);
                    j++;
                }
                else if (main[i] == '>' && i < main.Length - 2 && main[i + 2] == '/')
                {
                    j--;
                    copy.Append("\n");
                    copy.Append(' ', 2 * j);
                }
            }
            Console.WriteLine(copy);
        }

        static void _2044()
        {
            int n=Convert.ToInt32(Console.ReadLine());
            char symbol=' ';
            var dic = new Dictionary<string, string>();
            string key;
            int index;
            StringBuilder copy = new StringBuilder();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                str.Replace(" ","");               
                for (int j = 2; j < str.Length; j++)
                {
                    symbol = str[0];
                    copy.Append(str[j]);
                }
                dic.Add(symbol.ToString(), copy.ToString());
                copy.Clear();
            }
            foreach (var person in dic)
            {
                Console.WriteLine($"key: {person.Key}  value: {person.Value}");
                
            }
            key = Console.ReadLine();     
            while (key.Length != 0)
            {
                foreach (var symb in dic)
                {
                    if (key.Contains(symb.Value))
                    {
                        index = key.IndexOf(symb.Value);
                        if (index == 0)
                        {
                            key = key.Remove(0, symb.Value.Length);
                            stringBuilder.Append(symb.Key);
                            //Console.WriteLine($"{decode} {word}");
                        }
                    }
                }
            }
            Console.WriteLine(stringBuilder);
            


        }
        static void _2045()
        {
            string str=Console.ReadLine();
            StringBuilder list = new StringBuilder();
            string res = Regex.Replace(str, @"\s+", " ");
            bool probel = true;
            for (int i = 0; i < res.Length; i++)
            {
                list.Append(res[i]);
            }
            int index = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == ','||list[i]=='.'||list[i]=='!'||list[i]=='?')
                {
                    
                    if (list[i - 1] == ' ')
                    {
                        list.Remove(i-1, 1);
                        
                    }
                   
                }
            }
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == ',' || list[i] == '.' || list[i] == '!' || list[i] == '?')
                {

                    if (list[i + 1] != ' ')
                    {
                        list.Insert(i + 1, ' ');

                    }

                }
            }

            Console.WriteLine(list);
           
        }

        

        static void _2052(int n)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            int[] list2 = new int[k];
            int index = 0;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));

            }
            for (int i = 0; i < k; i++)
            {
                list2[i] = Convert.ToInt32(Console.ReadLine());
            }
            pips();




            void pips()
            {
                for (int i = 0; i < list2.Length; i++)
                {
                    for (int j = list.Count-1; j > -1; j--)
                    {
                        if ((j+1) % list2[i] == 0)
                        {
                            list.RemoveAt(j);
                            
                        }
                    }
                }
            }

                
            
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }
        }

        static void _2060(int n)
        {
            string People = "";
            SortedDictionary<string,List<int>> dict = new SortedDictionary<string,List<int>>();
            
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                People = Console.ReadLine();
                if (!dict.ContainsKey(People.Substring(0, People.IndexOf(' '))))
                {
                    dict[People.Substring(0, People.IndexOf(' '))] = new List<int> { Convert.ToInt32(People.Substring(People.IndexOf(' ') + 1)) };

        }
                else
                {

                    dict[People.Substring(0, People.IndexOf(' '))].Add(Convert.ToInt32(People.Substring(People.IndexOf(' ') + 1)));
                    
                }
            }
            
           
            foreach (var i in dict)
            {
                Console.WriteLine($"{i.Key} {String.Join(" ", Convert.ToInt32(i.Value.Average()))}");
            }

        }
       
        static void Main(string[] args)
        {
            //------------------------------------------
            // Console.WriteLine("1 zadanie");
            //int c = 5;
            //int d = 2;
            //Console.WriteLine(Sum(c, d));
            //------------------------------------------
            //Console.WriteLine("2 zadanie");
            //Console.WriteLine(Sum(5));
            ////------------------------------------------
            //Console.WriteLine("3 zadanie");
            //Console.WriteLine(Sum_3(5));
            ////------------------------------------------
            //Console.WriteLine("4 zadanie");
            //Console.WriteLine(Leap_year(2024));
            //------------------------------------------
            //Console.WriteLine("5 zadanie");
            //Console.WriteLine(firstMin(5));
            //------------------------------------------
            //Console.WriteLine("7 zadanie");
            //Console.WriteLine(Binary(64));
            //------------------------------------------
            //Console.WriteLine("6 zadanie");
            //Console.WriteLine(Baden(40));
            //-------------------------------------------
            //Console.WriteLine("8 zadanie");
            //Max_Gryz(5,10);
            //-------------------------------------------
            //Console.WriteLine("10 zadanie");
            //Evklid(40, 165);
            //-------------------------------------------
            //Console.WriteLine("11 zadanie");
            //Student(0);
            //-------------------------------------------
            //Console.WriteLine("12 zadanie");
            //Quadro(10,3,7,10);
            //--------------------------------------------
            //Console.WriteLine("13 zadanie");
            //Console.WriteLine(MinCnt(5));
            //--------------------------------------------
            //Console.WriteLine("15 zadanie");
            //Easy(25);
            //--------------------------------------------
            //Console.WriteLine("16 zadanie");
            //quadratic(1, 2, 64);
            //--------------------------------------------
            //Console.WriteLine("17 zadanie");
            //NKD_2(9,10);
            //--------------------------------------------
            // Console.WriteLine("18 zadanie");
            //Console.WriteLine(_2018(5));
            //--------------------------------------------
            //Console.WriteLine("19 zadanie");
            //_2019(4);
            //--------------------------------------------
            //Console.WriteLine("20 zadanie");
            //_2020(8);
            //--------------------------------------------
            //Console.WriteLine("21 zadanie");
            //_2021(5);
            //--------------------------------------------
            //Console.WriteLine("22 zadanie");
            //_2022(4);
            //--------------------------------------------
            //Console.WriteLine("23 zadanie");
            //_2023(2,0);
            //--------------------------------------------
            //Console.WriteLine("24 zadanie");
            //_2024(1);
            //Console.WriteLine("25 zadanie");
            //_2025(4,4);
            //Console.WriteLine("26 zadanie");
            //_2026(6);
            //---------------------------------------------
            //Console.WriteLine("27 zadanie");
            //_2027(5);
            //---------------------------------------------
            //Console.WriteLine("28 zadanie");
            //_2028(4);
            //---------------------------------------------
            //Console.WriteLine("29 zadanie");
            //_2029(5);
            //---------------------------------------------
            //Console.WriteLine("30 zadanie");
            //_2030(3);
            //---------------------------------------------
            //Console.WriteLine("31 zadanie");
            //_2031(6);
            //---------------------------------------------
            //Console.WriteLine("32 zadanie");
            //_2032(2,3);
            //---------------------------------------------
            //Console.WriteLine("33 zadanie");
            //_2033(5);
            //---------------------------------------------
            //Console.WriteLine("35 zadanie");
            //_2035(9);  //nado dodelatb
            //---------------------------------------------
            //Console.WriteLine("36 zadanie");
            //_2036(6);
            //----------------------------------------------
            //Console.WriteLine("37 zadanie");
            //_2037(2);
            //----------------------------------------------
            //Console.WriteLine("38 zadanie");
            //_2038();
            //----------------------------------------------
            //Console.WriteLine("39 zadanie");
            //_2039();
            //----------------------------------------------
            //Console.WriteLine("40 zadanie");
            //Console.WriteLine(_2040());
            //----------------------------------------------
            //Console.WriteLine("41 zadanie");
            //_2041();
            //----------------------------------------------
            //Console.WriteLine("42 zadanie");
            //_2042();
            //Console.WriteLine("43 zadanie");
            //_2043();
            //Console.WriteLine("44 zadanie");
            //_2044();
            //Console.WriteLine("45 zadanie");
            //_2045();
            //Console.WriteLine("52 zadanie");
            //_2052(4);
            Console.WriteLine("60 zadanie");
            _2060(4);
        }
    }
}



