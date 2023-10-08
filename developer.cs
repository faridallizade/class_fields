
namespace class_fields
{
class developer
    {
        public string name;
        public string surname;
        public int age;
        public int experience;
        public developer(string name,string surname,int experience)
        {
            this.name = name;
            this.surname = surname;

        }
        public void getInfo()
        {
            Console.WriteLine("Employer name : " + name + "\nEmployer surname : " + surname + "\nEmployer's experience : " + experience);
        }
    }
}
