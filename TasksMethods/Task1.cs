namespace TestTasks1.TasksMethods
{
    public static class Task1
    {
        public static int GetSumOfPrimeNumbers(int number) 
        {
            int sum = 0;
            for (int i = 2; i < number; i++)
            {
                if (IsPrime(i)) { sum = sum + i; }
            }
            return sum;
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
