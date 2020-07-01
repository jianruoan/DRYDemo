using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibraryDotNetCore
{
    public class EmployeeProcessor
    {
        public string GenerateEmployeeId(string firstName, string lastName)
        {
            string employeeId = $@"{ getSubstring(firstName, 4) }{ getSubstring(lastName, 4) }{ DateTime.Now.Millisecond }";

            return employeeId;
        }

        private string getSubstring(string input, int length)
        {
            string result = string.Empty;

            if (input.Length > length)
            {
                result = input.Substring(0, length);
            }
            else
            {
                result = input;
                while (result.Length < length)
                {
                    result = result + "*";

                }
            }
            int i = 1;
            if (i == 1)
            return result;
        }


    }
}
