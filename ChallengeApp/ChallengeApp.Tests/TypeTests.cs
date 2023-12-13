using System.Security;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestTwoEmployes()

        {
            //arange
            var employee1 = GetEmployee("Adam", "Kowal", 33);
            var employee2 = GetEmployee("Adam", "Fatima", 45);
            //act

            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        [Test]
        public void TestWithFloat()
        { 
            //arramge
            float mynumber1 = 115449454548484;
            float mynumber2 = 33256523525238283;
            //assert
            Assert.AreNotEqual(mynumber1, mynumber2);
        }
        [Test]
        public void TestNumberAreTheSame()
        {
            //arrange
            var number1 = 3;
            var number2 = 10;
            //act
            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void GetEmployeeShouldReturnDiffrentObcects()
        {
            //arrange 
            var employee1 = GetEmployee("Adam", "Goracy", 20);
            var employee2 = GetEmployee("Zosia", "Zimna", 14);
            //assert
            Assert.AreNotEqual(employee1.Name, employee2.Name);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
