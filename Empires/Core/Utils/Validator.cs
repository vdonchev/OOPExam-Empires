namespace Empires.Core.Utils
{
    using System;

    public static class Validator
    {
        public static void IsBiggerThan<T>(
            T value,
            T minRquired,
            string valueName,
            bool inclusive = false) where T : IComparable<T>
        {
            if (inclusive)
            {
                if (minRquired.CompareTo(value) > 0)
                {
                    throw new ArgumentException(
                        string.Format(EmpireConstants.ShouldBеBiggerThanOrEqual, valueName, minRquired));
                }
            }
            else
            {
                if (minRquired.CompareTo(value) >= 0)
                {
                    throw new ArgumentException(
                        string.Format(EmpireConstants.ShouldBеBiggerThan, valueName, minRquired));
                }
            }
        }
    }
}