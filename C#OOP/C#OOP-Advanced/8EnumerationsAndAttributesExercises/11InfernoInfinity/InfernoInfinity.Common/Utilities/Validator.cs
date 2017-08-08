namespace InfernoInfinity.Common.Utilities
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Validator<T>
    {
        public static bool ValidateRange(IEnumerable<T> array, int index)
        {
            if (index >= 0 && index < array.Count())
            {
                return true;
            }

            return false;
        }
    }
}