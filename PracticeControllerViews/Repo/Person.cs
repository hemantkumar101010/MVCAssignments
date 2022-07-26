namespace PracticeControllerViews.Repo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(String name,int age)
        {
            Age = age;
            Name = name;
        }
    }
    
}
