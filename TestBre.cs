namespace Dimitrije
{
    public class TesterBre
    {
        public static string Ispis(int n)
        {
            if ((n % 3 == 0) && (n % 5 == 0))
                return "TesterBre";

            if (n % 3 == 0)
                return "Tester";

            if (n % 5 == 0)
                return "Bre";

            return n.ToString(); 
        }
    }
}