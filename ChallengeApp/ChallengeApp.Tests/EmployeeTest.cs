namespace ChallengeApp.Tests
{
    public class Tests
    {
      
        [Test]
        public void ChechMethodGetStatisticsMin()
        {
            //arrange
            var employee = new Employee("Wiedzmin", "Siwobrody");
            employee.Addgrade(5);
            employee.Addgrade(18);
            employee.Addgrade(25);
            employee.Addgrade(-50);
            //act
            var statistics= employee.GetStatistics();
            //assert
            Assert.AreEqual(-50, statistics.Min);
        }
        [Test]
        public void CheckMethodGetStatisticsMax() 
        {
            //arrange
            var employee = new Employee("Wiedzmin", "Siwobrody");
            employee.Addgrade(5);
            employee.Addgrade(18);
            employee.Addgrade(25);
            employee.Addgrade(-50);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(25, statistics.Max);
        }
        [Test]  
        public void CheckMethodGetStatisticsAverage()
        {
            //arrange
            var employee = new Employee("Wiedzmin", "Siwobrody");
            employee.Addgrade(5);
            employee.Addgrade(18);
            employee.Addgrade(25);
            employee.Addgrade(49);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(24.25f,statistics.Average);
        }

    }
}