namespace FirstProjectApp.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChekingCorrectionOfSetingPoints()
        {
            var employee = new Employees("Wojtek", "Nowak", 32);

            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(4);
            employee.AddScore(6);
            employee.AddScore(2);
            employee.AddScore(-10);



            var result = employee.Result;

            Assert.AreEqual(14, result);

        }

        
    }
}