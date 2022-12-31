namespace laba_5
{
    internal class Task_3
    {
        public static int BranchesOnMassives()
        {
            List<string> numbers = new List<string>();
            while (true)
            {
                string str = Console.ReadLine();
                if (str != "end")
                {
                    numbers.Add(str);
                    continue;
                }
                else
                    break;
            }  
            numbers.ToArray();
            Console.Write("Изначальный массив : ");
            foreach (string str in numbers)
                Console.Write(str + " ,");
            Console.WriteLine();
            Console.Write("Новый массив: ");
            List<string> newNumbers = new List<string>();
            for(int i=0;i< numbers.Count;i++)
            {
                if (ConvertNumsInInt(numbers[i]) == 1)
                {
                    int k = Factorial(int.Parse(numbers[i]));
                    newNumbers.Add(k.ToString());
                }
                else if (ConvertNumsInInt(numbers[i]) == -1)
                    newNumbers.Add(numbers[i]);
                else
                {
                    string newstr = ConvertInFractionalNums(numbers[i]);
                    newNumbers.Add(newstr);
                }
            }
            newNumbers.ToArray();
            foreach (string str in newNumbers)
                Console.Write(str + "  ,");
            return 1 ;
        }
        public static int ConvertNumsInInt(string initialStr)
        {
            if(int.TryParse(initialStr,out int @int))
            {
                if(@int <0)
                    return -1;
                else
                    return 1;
            }
            else 
                return 0;
        }    
        public static string ConvertInFractionalNums(string newStr)
        {
                 
                 double newnum = double.Parse(newStr);
                 newnum = Math.Round(newnum, 2); 
                 newnum = newnum % 1;
                 double newresult = newnum * 100;
                 newresult = Math.Round(newresult, 0);                                      
            return newresult.ToString();
        }
        public static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
    } 
}
