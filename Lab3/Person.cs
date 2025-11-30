namespace Lab3
{
    public class Person
    {
        private string name;
        private int age;

        public void View() {
            Console.WriteLine($"{this.name} {this.age}");
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
