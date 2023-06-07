namespace h5task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> peoples = new Dictionary<uint, string>();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter persons ID");
                uint id = (uint)Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter person's name");
                string name = Console.ReadLine();
                peoples.Add(id, name);
            }
            Console.WriteLine("Enter the ID you're searching for");
            int expectedID = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            foreach (KeyValuePair<uint, string> kvp in peoples)
            {
                if (kvp.Key == expectedID)
                {
                    Console.WriteLine($"Person's name is {kvp.Value}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("There are no people with such ID's");
            }
        }
    }
}