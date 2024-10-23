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


        Paypal paypal1 = new Paypal(78, "subscription spotify", "ydriss@gmail.com");
        Paypal paypal2 = new Paypal(15, "subscription netflix", "ydriss@gmail.com");
        Paypal paypal3 = new Paypal(78, "subscription amazon", "ydriss@gmail.com");

        paypal1.AfficherDetails();
        paypal2.AfficherDetails();
        paypal3.AfficherDetails();
    }
}