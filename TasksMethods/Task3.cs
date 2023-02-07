using System;

namespace TestTasks1.TasksMethods
{
    public class Task3
    {
        public static int CountNeededLensPairs(int[] eyesightValues)
        {
            Array.Sort(eyesightValues);
            int pairsNeededCount = 0;
            bool hasSpareLens = false;
            for (int i = 0; i < eyesightValues.Length; ++i)
                    if (hasSpareLens && eyesightValues[i - 1] + 2 >= eyesightValues[i])
                    { hasSpareLens = false; }
                    else
                    {
                        hasSpareLens = true;
                        pairsNeededCount += 1;
                    }
            return pairsNeededCount;
        }
    }
}
