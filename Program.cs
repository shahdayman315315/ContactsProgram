namespace ContactsProgram
{
    internal class Program
    {
        static string csvfile = "file.csv";
        enum choices { AddNumber = 1, ViewNumbers };
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine($"1.AddNumber {'\n'}2.ViewNumbers ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddNumber();
                    break;
                case 2:
                    List<string> contacts= ViewNumbers();
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine(contact);
                    }
                    break;
            }
        }
        static void AddNumber()
        {
            Console.WriteLine("Enter the Name and the Number: ");
            string contactinfo = Console.ReadLine();
            using (var writer = new StreamWriter(csvfile,true)) { 

            writer.WriteLine(contactinfo);

            }
            Console.WriteLine("New contact has been Added");
        }
        static List<string> ViewNumbers()
        {
            List<string> contacts = new List<string>();
            using(var reader = new StreamReader(csvfile))
            {
                string contact;
                while((contact=reader.ReadLine()) != null)
                {
                    contacts.Add(contact);
                }
            }
            return contacts;
        }
    }
}
