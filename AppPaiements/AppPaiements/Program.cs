using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        CarteCredit cartecredit1 = new CarteCredit (50 , "food", 0965);
        CarteCredit cartecredit2 = new CarteCredit(50, "transport", 0965);
        CarteCredit cartecredit3 = new CarteCredit(50, "shopping", 0965);

        cartecredit1.AfficherDetails();
        cartecredit2.AfficherDetails();
        cartecredit3.AfficherDetails();


    }
}