﻿namespace _2022_10_22_WebApplication.Services.Lab5
{
    public class SomeClass
    {
        public string Print(string text)
        {
            try
            {
                return text.Length.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new EmployeeListNotFoundException("Custom exception fired");
            }
        }
    }
}
