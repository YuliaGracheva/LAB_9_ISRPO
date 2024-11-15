using System;
using System.IO;
using NUnit.Framework;
using lab9_ISRPO;

namespace ProgramTest
{
    public class Tests
    {
        [Test]
        public void Test_GetInput_ReturnsCorrectInput()
        {
            // Arrange
            var input = "Иван";
            var expectedOutput = "Введите ваше имя: ";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                using (var sr = new StringReader(input))
                {
                    Console.SetIn(sr);

                    // Act
                    var result = Program.GetInput(expectedOutput);

                    // Assert
                    Assert.AreEqual(input, result);
                }
            }
        }
    }
}
