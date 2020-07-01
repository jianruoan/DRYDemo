using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class EmployeeProcessor
    {
        // 这是内部操作函数
        public string GenerateEmployeeId(string firstName, string lastName)
        {
            string employeeId = $@"{ getSubstring(firstName, 4) }{ getSubstring(lastName, 4) }{ DateTime.Now.Millisecond }";

            return employeeId;
        }

        private string getSubstring(string input, int length)
        {
            string result= string.Empty;

            if( input.Length > length)
            {
                result = input.Substring(0, length);
            }
            else
            {
                result = input;
                while( result.Length < length)
                {
                    result = result + "*";

                }
            }

            return result;
        }


    }
}
