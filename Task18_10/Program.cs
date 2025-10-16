using System.Collections.Immutable;

namespace Task18_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task1
            //int[] nums = { 5, 4, 6 };
            //Factorial(nums);



            //Task2
            //int[] nums = { 7, 12, 5, 8 };
            //RemoveSmallNumber(nums);

            //Task3
            //string word=Console.ReadLine();
            //String(word);



            //Task4
            //int num=Convert.ToInt32(Console.ReadLine());
            //SadeMurekkeb(num);





            //Task5
            //int N=Convert.ToInt32(Console.ReadLine());
            //int M = Convert.ToInt32(Console.ReadLine());
            //Polindrom(N, M);


            //Task6
            //string word=Console.ReadLine();
            //MostUsedLetter(word);


            //Task7
            //int a =Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //UcbucaqNovu(a, b, c);


            //Task8
            //string word=Console.ReadLine();
            //OrtaHerf(word);


            //Task9
            //int number=Convert.ToInt32(Console.ReadLine());
            //SadeReqemCemi(number);

            //Task10
            //int num=Convert.ToInt32(Console.ReadLine());
            //BigNumber(num);


            //Task11
            //int number=Convert.ToInt32(Console.ReadLine());
            //SortedOrNot(number);

            //Task12
            //int number = Convert.ToInt32(Console.ReadLine());
            //SameNumberOrNot(number);


            //Task13







        }
        public static void Factorial(int[] nums)
        {
            for(int i=0; i<nums.Length; i++)
            {
                int factorial = 1;
                for(int j = 1; j <= nums[i];j++)
                {
                    factorial *= j;
                }
                nums[i] = factorial;
                Console.WriteLine(nums[i]);
            }
            
        }
        public static void RemoveSmallNumber(int[] nums)
        {
            int min = nums[0];
            for(int i=0;i<nums.Length;i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            for(int j=0;j<nums.Length;j++)
            {
                if (nums[j]!=min)
                {
                    Console.WriteLine(nums[j]);
                }
            }
            
        }
        public static void String(string word)
        {
            for(int i=0;i<=word.Length;i++)
            {
                int count = 0;
                char letter = ' ';
                for(int j=0;  j<word.Length;j++)
                {
                    if (word[i] == word[j])
                    {
                        count++;
                        letter = word[j];
                    }
                }
                if(count==1)
                {
                    Console.WriteLine(letter);
                    break;
                }
            }

        }
        public static void Polindrom(int N ,int M)
        {
            if (M > N)
            {
                for (int i = N; i <= M; i++)
                {
                    int len = i;
                    int count = 0;
                    int currentnum = i;
                    int num = i;
                    while (len > 0)
                    {
                        len /= 10;
                        count++;
                    }
                    int reversednum = 0;
                    while (currentnum > 0)
                    {
                        count--;
                        reversednum += Convert.ToInt32((currentnum % 10) * Math.Pow(10, count));
                        currentnum /= 10;
                       
                    }
                    if (num == reversednum)
                    {
                        Console.WriteLine(num);
                    }

                }
            }
            else
                Console.WriteLine("Invalid Input");
        }



        public static void SadeMurekkeb(int num)
        {
            int count = 0;
            if (num < 2)
                Console.WriteLine("ne sadedir ne de murekkeb");
            else
            {
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        Console.WriteLine("murekkebdir");
                        break;
                    }

                }
                if (count == 0)
                    Console.WriteLine("sadedir");
            }
                
        }
        public static void MostUsedLetter(string word)
        {
            int max = 0;
            char letter = ' ';
            for(int i=0; i < word.Length; i++)
            {
                int count = 0;
                for(int j=0; j < word.Length; j++)
                {
                    if(word[i] == word[j])
                    {
                        count++;
                       
                    }
                }
                if(count>max)
                {
                    max = count;
                    letter = word[i];
                }
                
            }
            Console.WriteLine(max);
            Console.WriteLine(letter);
        }

        public static void UcbucaqNovu(int a,int b,int c)
        {
            if ((a + b > c && b + c > a && a + c > b) && (a > 0 && b > 0 && c > 0))
            {
                if (a * a + b * b == c * c || c * c + b * b == a * a || a * a + c * c == b * b)
                {
                    Console.WriteLine("duzbucaqli ucbucaq");
                }
                else if (a == b && a == c)
                    Console.WriteLine("beraberterefli ucbucaqdir");
                else if (a == c || a == b || b == c)
                    Console.WriteLine("beraberyanli ucbucaqdir");
                else
                    Console.WriteLine("muxtelifterefli ucbucaqdir");
            }
            else
                Console.WriteLine("Terefleri duzgun daxil edin");
        }
        public static void OrtaHerf(string word)
        {
            if (word.Length % 2 == 0)
            {
                Console.WriteLine($"{word[(word.Length / 2) - 1]} {word[word.Length / 2]}");
            }
            else
                Console.WriteLine(word[word.Length / 2]);

        }



        public static void SadeReqemCemi(int number)
        {
            int digit = 0;
            int sum = 0;
            while(number>0)
            {
                digit = number % 10;
                number /= 10;
                int count = 0;
                if(digit>=2)
                {
                    for (int i = 2; i * i <= digit; i++)
                    {
                        if (digit % i == 0)
                        {
                            count++;
                            break;
                        }
                    }
                    if (count == 0)
                        sum += digit;
                }
                
            }
            Console.WriteLine(sum);

        }


        public static void BigNumber(int num)
        {
            int[] numbers = new int[3];
            int i = 0;
            while(num > 0)
            {
                numbers[i] = num % 10;
                num /= 10;
                i += 1;
            }
            Array.Sort(numbers);
            int newnum = numbers[2] * 100 + numbers[1] * 10 + numbers[0];
            Console.WriteLine(newnum);
        }


        public static void SortedOrNot(int number)
        {

            int count = 0;
            int countsorted = 0;
            while (number > 0)
            {
                int digit = number % 10;
                count++;
                number /= 10;
                if (digit > number % 10)
                {
                    countsorted++;
                }

            }
            if (count == countsorted)
            {
                Console.WriteLine("Artan siradir");
            }
            else
                Console.WriteLine("Artan sira deyil");
        }



        public static void SameNumberOrNot(int number)
        {
            int count = 0;
            int countsame = 0;
            int sonreqem = number % 10;
            while (number > 0)
            {
                int digit = number % 10;
                count++;
                if (digit == sonreqem)
                {
                    countsame++;
                    sonreqem = digit;
                }
                number /= 10;

            }
            if (count == countsame)
            {
                Console.WriteLine("Butun reqemler eynidir");
            }
            else
                Console.WriteLine("Ferqli reqemler var");
        }
    }
}
