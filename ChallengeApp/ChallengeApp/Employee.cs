namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }


        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }
        public void Addscore(int score)
        {
            this.score.Add(score);
        }
        public int Rating
        {
            get
            {
                return this.score.Sum();
            }
        }
    }
}
