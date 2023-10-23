using ADOes01.adoDb;

namespace ADOes01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdoDb ado = new AdoDb();
            //
            ado.ClientiUpdate();
            Console.WriteLine("----------------------");
            ado.ClientiRead();
            Console.WriteLine("-------APP TERMINATA ---------");

        }
    }
}