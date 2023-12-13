namespace ChallengeApp.Tests
{
    public class Tests
    {
      
        [Test]
        public void WhenEmployeeColectScores_ShouldReturnCorrectSum()
        {
            //arrange
            var employee = new Employee("Wiedzmin", "Siwobrody", 85);
            //act
            employee.Addscore(5);
            employee.Addscore(18);
            employee.Addscore(25);
            employee.Addscore(-50);
            //assert
            Assert.AreEqual(-2, employee.Rating);
        }
    }
}