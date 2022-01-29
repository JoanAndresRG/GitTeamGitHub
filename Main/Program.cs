// See https://aka.ms/new-console-template for more information

namespace GitTeams;

class Program
{
    public static void Main(string[] args)
    {


    }
    //Class Person 
    public class Person
    {
        //Encapsulamiento de atributos de la clase
        string name  { get; set; }
        string email { get; set; }
        int age { get; set; }
        string address { get; set; }
        //Metodo de la clase Person
        public string Talk(string name)
        {
            return $"Hello {name} how are you?";
        }
    }
}
