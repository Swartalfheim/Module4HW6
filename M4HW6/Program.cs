namespace M4HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Artists.ToList();
            }
            Console.Read();
        }
    }
}