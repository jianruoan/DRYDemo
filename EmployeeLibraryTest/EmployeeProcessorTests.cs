using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmployeeLibraryTest
{
    public class EmployeeProcessorTests
    {
        [Fact]
        public void GenerateEmployeeId_ShouldOk()
        {
            //arrange
            EmployeeProcessor processor = new EmployeeProcessor();
            string firstName = "Will";
            string lastName = "Smith";

            string expectId = "WillSmit";

            //act
            string employeeId = processor.GenerateEmployeeId(firstName, lastName);
            string actualEmployeeId = employeeId.Substring(0, 8);

            //assert
            Assert.Equal(expectId, actualEmployeeId);
        }


        [Theory]
        [InlineData("Willson", "Smith", "WillSmit")]
        [InlineData("Will", "Smith", "WillSmit")]
        //[InlineData("Wi", "Smith", "Wi**Smit")]
        //[InlineData("Wi", "Sm", "Wi**Sm**")]
        public void GenerateEmployeeId_ShouldWork(string firstName, string lastName, string expectId)
        {
            //arrange
            EmployeeProcessor processor = new EmployeeProcessor();
            //string firstName = "Will";
            //string lastName = "Smith";
            //string expectId = "WillSmit";

            //act
            string employeeId = processor.GenerateEmployeeId(firstName, lastName);
            string actualEmployeeId = employeeId.Substring(0, expectId.Length);

            //assert
            Assert.Equal(expectId, actualEmployeeId);
        }
    }
}
