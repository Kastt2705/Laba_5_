namespace laba_5
{
    internal class Task_1
    {
        public static void doubleDefinition()
        {
            double nan2 = double.NaN;
            while (true)
            {

                string num123 = Console.ReadLine();
                if (int.TryParse(num123, out int @int))
                {
                    Console.WriteLine((char)@int);
                    break;
                }
                else if (num123 == "q")
                {
                    break;
                }
                else if (double.TryParse(num123, out double @double))
                {
                    if (@double == nan2)
                    {
                        break;
                    }
                    else
                    {
                        nan2 = @double;
                    }
                }
                else if (num123 == "q")
                {
                    break;
                }

            }

        }
    }
        
    }
    

