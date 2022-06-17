using Order_CLI.Controllers;
using Order_CLI.Models;

//Örnek Kayıtlı Müşteriler
CustomerListModel.customerList.Add(new Customers("11111111111", "Erhan", "Yükselen", "123"));
CustomerListModel.customerList.Add(new Customers("22222222222", "Ayberk", "Kalyoncu", "456"));
CustomerListModel.customerList.Add(new Customers("33333333333", "Faruk", "Erol", "789"));
//Örnek Kayıtlı Siparişler
CustomerListModel.productList.Add(new Products((Kind)1, (Color)1, (Size)2, "12","11111111111"));
CustomerListModel.productList.Add(new Products((Kind)2, (Color)3, (Size)3, "4","11111111111"));
CustomerListModel.productList.Add(new Products((Kind)3, (Color)2, (Size)4, "21","33333333333"));


while (true)
{

    //Console ilk açıldığı zaman gözükecek ekran
    Console.WriteLine("Sipariş oluşturmak için 1");
    Console.WriteLine("Sipariş görüntülemek için 2");

    
    string istek = Console.ReadLine();

    
    if (istek == "1")  //Sipariş oluşturmak için müşteri 1 e basarsa uygulayacağı adımlar
    {
        //Kayıtlı müşteri varsa bilgilerini getirir, yoksa çağırılan methodlar sayesinde yeni kayıt oluşturur
        string Tc = Methodlar.TcAl();
        Methodlar.YeniSiparis(Tc);
    }
    else if(istek == "2")  //Sipariş aramak için müşteri 2 e basarsa uygulayacağı adımlar
    {
        //Sipariş arama işlemlerini yapar.
        Console.WriteLine("Sipariş aramak için TC giriniz.");
        string tc = Console.ReadLine();
        Methodlar.SiparisGoruntule(tc);

    }

}




