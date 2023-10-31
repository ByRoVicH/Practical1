using System;

namespace Lib_12
{
    public class RandomSumCalculator
    {
        public string CalculateRandomSum(int n)
        {
            Random random = new Random();
            int sum = 0;
            string generatedNumbers = "";

            for (int i = 0; i < n; i++)
            {
                int randomNumber = random.Next(0, n + 1);
                sum += randomNumber;
                generatedNumbers += randomNumber + " ";
            }

            string result = $"Числа: {generatedNumbers.Trim()}\nСумма: {sum}";
            return result;
        }
    }
}
