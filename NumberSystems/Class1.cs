using System;

namespace NumberSystems
{
    public class Class1
    {
        public string CalculateNumberSystems(int i, string num)
        {
            int m = Convert.ToInt32(num);
            switch (i)
            {
                case 2:
                    return Convert.ToString(m, 2).ToUpper();
                case 8:
                    return Convert.ToString(m, 8).ToUpper();
                case 16:
                    return Convert.ToString(m, 16).ToUpper();
                default:
                    return Convert.ToString("Данная система счисления не существует").ToUpper();

            }
        }
    }
}