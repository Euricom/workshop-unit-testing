﻿namespace CodeCoverage
{
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            return checked(value1 + value2);
        }
    }
}
