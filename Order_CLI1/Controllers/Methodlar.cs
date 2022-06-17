using Order_CLI.Models;

namespace Order_CLI.Controllers;

public static class Methodlar
{
    //Müşteriden TC kimlik numarasını alıp kayıt olup olmamasına göre aksiyon gösteren method
    public static string TcAl()
    {
        while (true)
        {
            
            Console.WriteLine("Yeni Sipariş Oluşturmak için:");
            Console.WriteLine("Lütfen TC kimlik numarası giriniz : ");
            bool t = true;
            string TC = Console.ReadLine();

            if (CustomerListModel.customerList.Count == 0 && t == true)//Listede hiç kayıt yoksa eşleşme aramadan işlemleri yapar.
            {
                return TC;
            }


            for (int i = 0; i < TC.Length; i++)
            {
                if (!Char.IsDigit(TC[i])) //Sadece rakam girilmesini sağlar
                {
                    Console.WriteLine("Sadece Rakam Giriniz!");
                    t = false;
                    break;
                }
                else if (TC.Length != 11) //TC nin 11 haneye eşit olmasını sağlar
                {
                    Console.WriteLine("11 hane girmek zorundasınız!");
                    t = false;
                    break;
                }


            }

            
            for (int i = 0; i < CustomerListModel.customerList.Count; i++)
            {

                if (TC == CustomerListModel.customerList[i].TC) //Listedeki bütün kullanıcıları dolaşarak tc eşleşmesi arar.
                {
                    //Listede böyle bir kayıt varsa yazdırır.
                    Console.WriteLine("Böyle bir kayıt vardır."); 
                    KayitGoruntule(TC);
                    return null;
                }
                else if (t == true || i== CustomerListModel.customerList.Count) //Listeyi tamamen dolaşıp eşleşme bulamadığımızda kayıt olmadığını varsayar.
                {
                    // Listede böyle bir kayıt yoksa yeni kayıt oluşturmaya yönlendirir.
                    YeniKayit(TC);
                    KayitGoruntule(TC);
                    return TC;
                }
            }
   


        }
    }

    //Yeni kayıt oluşturmak için kullanıcıdan isim, soyisim, gsm bilgilerini alır
    public static void YeniKayit(string tc)
    {
        Console.WriteLine("Kayıt Bulunamadı. Oluşturmak için:");
        Console.WriteLine(" Lütfen isim giriniz             : ");
        string name = Console.ReadLine();
        Console.WriteLine(" Lütfen soyisim giriniz          : ");
        string surname = Console.ReadLine();
        Console.WriteLine(" Lütfen telefon numarası giriniz : ");
        string gsm = Console.ReadLine();
        CustomerListModel.customerList.Add(new Customers(tc, name, surname, gsm)); //Listeye kayıt ekler

    }
    //Liste içerisindeki kayıtları görüntüler 
    public static void KayitGoruntule(string Tc)
    {
        for (int i = 0; i < CustomerListModel.customerList.Count; i++)
        {
            if (CustomerListModel.customerList[i].TC == Tc)
            {
                Console.WriteLine("");
                Console.WriteLine("Musteri Bilgileri ");
                Console.WriteLine("Tc: {0}", CustomerListModel.customerList[i].TC);
                Console.WriteLine("isim: {0}", CustomerListModel.customerList[i].Name);
                Console.WriteLine("Soyisim: {0}", CustomerListModel.customerList[i].Surname);
                Console.WriteLine("Telefon Numarası: {0}", CustomerListModel.customerList[i].GSM);
            }
        }
    }

    //Yeni sipariş oluşturken tip, renk, beden, adet bilgilerini seçtirir
    public static void YeniSiparis(string tc)
    {
       
        Console.WriteLine("");
        Console.WriteLine("Yeni Sipariş oluşturmak için:");
        Console.WriteLine("Tişört Tipini Seçiniz -> Yuvarlak Yaka(1) Bisiklet Yaka(2) V Yaka(3) Polo Yaka(4) :");
        Kind kind = Enum.Parse<Kind>(Console.ReadLine());
        Console.WriteLine("Renk Seçiniz -> Siyah(1) Beyaz(2) Mavi(3) Kırmızı(4) Turuncu(5)      :");
        Color color = Enum.Parse<Color>(Console.ReadLine());
        Console.WriteLine("Beden Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        Size size = Enum.Parse<Size>(Console.ReadLine());
        Console.WriteLine("Adet Sayısını Giriniz              :");
        string quantity = Console.ReadLine();
       
        CustomerListModel.productList.Add(new Products(kind, color, size, quantity, tc));
        Console.WriteLine(" ");
        Console.WriteLine("Siparişiniz Alındı İyi Günler :)");

        SiparisGoruntule(tc); //Sipariş oluşturduktan sonra siparişi getirir

    }
    //Oluşturulan siparişi görüntüler
    public static void SiparisGoruntule(string Tc)
    {
        bool x=true;
        for (int i = 0; i < CustomerListModel.productList.Count; i++)
        {
            if (CustomerListModel.productList[i].TC == Tc)
            {
                Console.WriteLine("Siparis Bilgileri ");
                Console.WriteLine("Model: {0}", MUsefulMethods.EnumHelpers.GetDescription(CustomerListModel.productList[i].Kind)); //Helper kullanarak enumları ayrı yazdırmamızı sağlar
                Console.WriteLine("Renk: {0}", CustomerListModel.productList[i].Color);
                Console.WriteLine("Boyut: {0}", CustomerListModel.productList[i].Size);
                Console.WriteLine("Adet: {0}", CustomerListModel.productList[i].Quantity);
                Console.WriteLine(" ");
                x= false;
            }

        }
        if (x)
        {
            Console.WriteLine("Böyle bir sipariş bulunamadı önce kayıt oluşturunuz.");
            Console.WriteLine(" ");
        }
     

    }

}
