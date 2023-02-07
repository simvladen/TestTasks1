namespace TestTasks1.TasksMethods
{
    public static class Task2
    {
        public static string CountChange(int price, int pay)
        {
            int change = pay - price;
            int[] billValues = { 5000, 2000, 1000, 500, 200, 100, 50, 10, 5, 2, 1};
            string countedChange = "";
            for (int i = 0; i < billValues.Length; i++)
            {
                int count = change / billValues[i];
                change = change % billValues[i];
                if (count > 0)
                {
                    countedChange += $"{billValues[i]} руб: {count} шт. ";
                }
            }
            return countedChange;
        }
    }
}
