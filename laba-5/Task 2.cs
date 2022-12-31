namespace laba_5;

internal class Task_2
{
    public static bool IsNumber(string num)
    {
        if (num[0] == '-')
        {
            for (int i = 1; i < num.Length; i++)
            {
                if (num[0 + i] >= '0' && num[0 + i] <= '9')
                    continue;
                else
                {
                    return false;
                }
            }
        }
        else
        {
            for (int k = 0; k < num.Length; k++)
            {
                if (num[0 + k] >= '0' && num[0 + k] <= '9')
                    continue;
                else
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static int SumDigits(string num)

    {
        if (num[0] == '-')
        {
            int sum = 0;
            for (int j = 1; j < num.Length; j++)
            {
                sum += num[j] - '0';
            }
            return sum;
        }
        else
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i] - '0';
            }
            return sum;
        }
    }
}
