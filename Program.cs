using System.Xml.Linq;

namespace class_fields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            frontend firstEmployer = new frontend();
            frontend.name = "Jason";
            frontend.surname = "Momoa";
            frontend.experience = 4;

            backend secEmployer = new backend();
            backend.name = "Elvis";
            backend.surname = "Presley";
            backend.experience = 4;
            
        }
    }
}