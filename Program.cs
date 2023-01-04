namespace BookForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basliqsiz calismalar
            //Console.WriteLine("Iki reqemli ededi daxil edin");
            //string input = Console.ReadLine();
            //if (input.Length < 2 || input.Length > 2)
            //{ Console.WriteLine("Eded iki reqemli deyil");
            //return;}
            //int number = int.Parse(input);
            //int lastDigit = number % 10;
            //number = number / 10;
            //Console.WriteLine($"{number} {lastDigit}");


            //short Maxdeyer = short.MaxValue;
            //short MinDeger = short.MinValue;
            //Console.WriteLine();

            //short maxDeyer = short.MaxValue;
            //short minDeyer = short.MinValue;

            //Console.WriteLine(maxDeyer);
            //Console.WriteLine(minDeyer);

            ////Test
            //int birinciDeyisgen = 1234;
            //int ikinciDeyisgen = -1234;

            //Console.WriteLine($"Birici Deyisgen = {birinciDeyisgen}");
            //Console.WriteLine($"Ikinci Deyisgen = {ikinciDeyisgen}");




            ////Max-Min deyerleri tapmaq
            //int MaxDeyer = int.MaxValue;
            //int MinDeyer = int.MinValue;

            //Console.WriteLine($"Int veri tipinin max deyeri = {MaxDeyer}");
            //Console.WriteLine($"Int veri tipinin min deyeri = {MinDeyer}");

            //double y = 123;
            //Console.WriteLine(y);

            //double minDeyer = double.MinValue;
            //double maxDeyer = double.MaxValue;

            //Console.WriteLine(minDeyer);
            //Console.WriteLine(maxDeyer);

            //float onluq_kesr1 = 11.5f;
            //float onluq_kesr2 = 13.123f;

            //Console.WriteLine(onluq_kesr1);
            //Console.WriteLine(onluq_kesr2);

            //float maksQiymet = float.MaxValue;
            //float minQiymet = float.MinValue;

            //Console.WriteLine(maksQiymet);
            //Console.WriteLine(minQiymet);


            //char karakter = 'S';
            //Console.WriteLine(karakter);

            //string ad = "Samir";
            //string soyad = "Jabrayilzada";

            //Console.WriteLine(ad);
            //Console.WriteLine(soyad);

            //bool karakter = true;
            //bool karakter1 = false;
            //Console.WriteLine(karakter);
            //Console.WriteLine(karakter1);


            //bool sonuc = 10 > 5;
            //bool sonuc1 = 4 > 8;

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc1);

            //object a = 70;
            //object b = "samir";
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int eded1 = 35;
            //int eded2 = 13;
            //int eded3 = 7;

            //int netice = eded1 + eded2 + eded3;
            //Console.WriteLine(netice);

            //int netice1 = eded1 - eded2;

            //Console.WriteLine(netice1);

            //int netice = (eded1 + eded2) - eded3;
            //Console.WriteLine(netice);

            //int netice = (eded1 / eded3) * eded2;

            //Console.WriteLine(netice);


            //int eded1 = 20;
            //int eded2 = 6;

            //int netice = 20 % 6;

            //Console.WriteLine(eded1%eded2);
            #endregion End of Basliqsiz calismalar

            #region  (++;--) Artirma Azaltma

            //int sayi = 20;
            //sayi++;
            //Console.WriteLine(sayi);


            #endregion End of (++;--)

            #region Atama operatoru (=)

            //Atama operatoru : =

            //int yas = 20;

            //burda 20 deyeri (=) - vasitesi ile yas degiskenine daxil edilir ve tutulur.


            #endregion End of Atama (=)

            #region Beraberdir operatoru (==)

            // Beraberdir operatoru : ==

            //int sayi1 = 4;
            //int sayi2 = 4;

            //bool yoxla = sayi1 == sayi2;

            //Console.WriteLine(yoxla);

            //int number1 = 5;
            //int number2 = 6;

            //bool checkout = number1 == number2;

            //Beraberlikleri bu operator ile bildireceyik
            //Bool reqemlerin beraber olub olmadiqlarini yoxladi ve True-False oldugunu bildirdi

            #endregion End of (==)

            #region Beraber deyil operatoru (!=)

            //Beraber deyil operatoru : !=

            //int eded1 = 4;
            //int eded2 = 3;

            //bool yoxla = 3 != 4;

            //Console.WriteLine(yoxla);

            ////Cavab True olur , 3 ferqlidir 4den.

            //int number1 = 5;
            //int number2 = 5;

            //bool checkout = number1 != number2;

            //Console.WriteLine(checkout);
            //Cavab False olur , 5 beraberdir 5e sert odenmediyi ucun False olur.

            #endregion End of (!=) beraber deyil

            #region Boyukdur (>) , Boyuk/Beraberdir ( >= )

            //boyukdur operatoru : >
            //Boyuk beraberdir operatoru : >=

            //int yas = 20;

            //bool checkout = yas > 19;
            //bool yoxla = yas >= 20;

            //Console.WriteLine(checkout);
            //Console.WriteLine(yoxla);

            //Her ikisi True cixacaq cunki boyuk ve boyuk/beraber sertleri odenir

            #endregion End of Boyukdur(>) ; B/beraber(>=)

            #region Kicikdir (<) ; Kicik/b (<=)

            //Kicikdir operatoru : <
            //Kicik beraber : <==

            //int yas = 21;

            //bool checkout = yas < 30;
            //bool yoxla = yas <= 21;

            //Console.WriteLine(checkout);
            //Console.WriteLine(yoxla);

            //Her ikisi Ture olacak , Her iki kicik ve kicik/b sertleri odenir

            #endregion End of Kicik(<) ; Kicik/b(<=) 

            #region && (ve) operatoru 

            // Ve operatoru : &&

            //int number1 = 8;
            //int number2 = 10;
            //int number3 = 20;

            //bool checkout = number2 > number1 && number2 < number3;
            //Console.WriteLine(checkout);
            ////Burda Ture olacaq cunki butun sertler odenir

            //bool yoxla = number1 == number2 && number2 < number3;
            //Console.WriteLine(yoxla);
            ////Burda False olacaq cunki sertlerden biri sehvdir
            ////Sertlerden biri False oldugu halda istenilen sert True olsa bele , biri False oldugu ucun Console Ekraninda False olur.

            #endregion End of && (ve)

            #region || (ve ya) operatoru 

            //// Ve ya operatoru : ||

            //int number1 = 4;
            //int number2 = 4;
            //int number3 = 16;

            //bool checkout = number1 == number2 || number1 > number3;
            //Console.WriteLine(checkout);
            ////Ve ya operatorunda sertlerden biri dogru oldugu halda Boolean True olur (diger sertler false olsa bele)

            //bool checkout2 = number2 == number3 || number2 > number3;
            //Console.WriteLine(checkout2);
            ////Ve ya operatorunda Boolean yeni sertler False oldugu halda Console erkaraninda False cixir.

            #endregion End of (||) veya

            #region Deyil (!) operatoru

            //Deyil operatoru : !

            //bool a = true;
            //bool b = false;

            //Console.WriteLine(!a);
            //Console.WriteLine(!b);
            // Deyil operatoru her hansi bir deyeri eksine cevirir (True--False) ; (False--True)


            #endregion

            #region Elave operatorlar (+=) ; (-=) ; (/=) ; (*=)

            // (+=) ; (-=) ; (/=) ; (*=)

            //int a = 6;
            ////a--;
            ////a -= 5;
            ////a += 4;
            ////a /= 2;
            //a *= 2;


            //Console.WriteLine("a - nin degeri : "  +  a);

            #endregion End of  (+=) ; (-=) ; (/=) ; (*=)

            #region BreakPoint ; ToolTip
            //Yazdigin kodlarin nece islediyine baxaraq kodu daha yaxsi anlaya bilerik

            //int a = 3;
            //int b = 5; 
            //int c = 6;

            //int netice = a + b + c;

            //Console.WriteLine(netice);
            //// (Console.WriteLine) isfadesini yazarken qiraqda verilen ornekler TollTip adlanir ordan baxaraq kod haqqinda oxuya bilerik.


            #endregion End of BreakPoint;ToolTip

            #region İstifadəçidən dəyər əldə etmək (Console.ReadLine()) #Jarvis
            //Console ekranina girdikde ekranda cixan yazidir. Yeni istifadeciden input yeni deyer aliriq.

            //Console.WriteLine("Zəhmət olmasa adınızı daxil edin :");

            //string ad = Console.ReadLine();

            //Console.WriteLine("Zəhmət olmasa soyadınızı daxil edin :");

            //string soyad= Console.ReadLine();

            //Console.WriteLine("Xoş geldiniz Samir bey");

            //string xosgorduk = Console.ReadLine();

            //Console.WriteLine("Sizə necə kömək edə bilərəm?");

            //string hava = Console.ReadLine();

            //Console.WriteLine("Bu gün hava günəşlidir, Əsl gəzmək havasıdır" );

            //string jarvis = Console.ReadLine();

            //Console.WriteLine("Efendim size icin bilet almak icin islem baslatmami ister misiniz?");

            //string yox = Console.ReadLine();

            //Console.WriteLine("Buyurun efendim");

            //Console.WriteLine("Lutfen adinizi giriniz");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Lutfen soyadinizi giriniz");
            //string soyisim = Console.ReadLine();

            //Console.WriteLine("Kullanici adiniz : " + isim);
            //Console.WriteLine("Kullanici soyadiniz : " + soyisim);

            #endregion End of Istifadeciden deyer elde etmek

            #region Tur donusumleri (Parse) ; (Convert.ToInt32) ; (ToString) #1

            //Her iki teref eyni tipde olmalidir
            //int a = 5;

            //byte b = (byte)a; //burda int veri tipini (byte) veri tipine donusdurduk.

            ////deyisenin hansi veri tipine aid oldugunu oyrenmek  ( deyisen.GetType() )

            //Console.WriteLine(b.GetType()); //hansi tip oldugunu gosterir ekranda
            //Console.WriteLine(b); // int--byte donusdu ve qiymeti ekrana eks olunur

            // STRING VERI TIPINDEN INT VERI TIPINE DONUS ETDIK
            //string sayi1 = "1";
            //string sayi2 = "2";

            //Console.WriteLine(sayi1 + sayi2); //ekranda 12 cixacaq cunki (string) toplam vs. isleri ede bilmir

            ////int a = int.Parse(sayi1); //string veri/t-i int veri tipine donusdurduk
            ////int b = int.Parse(sayi2);   

            //int a = Convert.ToInt32(sayi1); //bu curde donusdurmek olur
            //int b = Convert.ToInt32(sayi2);

            ////INT VERI TIPINDEN STRING VERI TIPINE DONUS YAPDIK

            //int sayi1 = 23;
            //int sayi2 = 27;

            //Console.WriteLine(sayi1 + sayi2); //Burda int-le toplamada 50 alinir

            //string a = sayi1.ToString(); //ToString her hansi veri tipini String v/t cevirir.
            //string b = sayi2.ToString();
            //Console.WriteLine(a + b);  // burda 2327 olur cunki string v/t ededleri yan-yana edir.

            ////DOUBLE V/T STRING VERI TIPINE DONUSDURMEK

            //double number1  = 2.5;
            //double number2= 3.7;

            //Console.WriteLine(number1+number2);

            //string c = number1.ToString();
            //string d = number2.ToString();  
            //Console.WriteLine(c + d);

            //DOUBLE V/T INT V/T DONUSDURMEK

            //double sayi1 = 2.6;
            //double sayi2 = 5.8;

            //Console.WriteLine(sayi1+sayi2);

            //int a = Convert.ToInt32(sayi1);
            //int b = Convert.ToInt32(sayi2);

            //Console.WriteLine(a.GetType());
            //Console.WriteLine(a+b); //int veri tipi kesr hisseleri atir ve ya yuvarlaqlasdirir.

            #endregion End of Donusum 1

            #region Istifadeciden alinan 2 deyerin toplamini ekrana yazdiran program. (donusum) #2



            ////Istifadeciden alinan deyer ler string v/t- de olur.


            //Console.WriteLine("Zehmet olmasa istifadeci yasinizi daxil edin");

            //string istifadeci_yasi = Console.ReadLine();
            //int istifadeci_yasiInt = int.Parse(istifadeci_yasi); //Int-e cevirmeyimiz hesablamalar ucun lazimidir.

            //Console.WriteLine("Istifadeci yasi : " + istifadeci_yasiInt);

            //Istifadeciden alinan 2 deyerin toplamini ekrana yazdiran program.

            //Console.Write("Birinci ededi girin : ");

            //int birinciInt = int.Parse(Console.ReadLine());


            ////string birinci = Console.ReadLine();
            ////int birinciInt = int.Parse(birinci); // yuxaridaki ifade kimi qisa yaza bilerik.

            //Console.Write("Ikinci ededi girin : ");

            //int ikinciInt = int.Parse(Console.ReadLine());

            ////string ikinci = Console.ReadLine();
            ////int ikinciInt = int.Parse(ikinci);

            //Console.WriteLine("Ededlerin cemi : " + (birinciInt+ikinciInt));

            #endregion End of donusum #2

            #region Karar yapilari (if/else) (Bal daxil etdikde , netice gosteren program (calisqan/Calisqan deyil)

            //Sagirdin bali 50-den boyukdurse calisqan , deyilse calisqan deyil yazdiran program ciktisi kodlayin.

            //Console.Write("Sagirdin balini daxil edin : ");

            //int n = int.Parse(Console.ReadLine());

            //int bal = n;

            //if (bal > 50) 
            //{
            //    Console.WriteLine("Sagird calisqandir");

            //}
            //else 
            //{
            //    Console.WriteLine("Sagird calisqan deyil");
            //}


            #endregion End of (else/if) bal daxil etmek

            #region (Else/If) Kullanci 3 tane not giriyor ver ortalama ve aldigi not cikiryor

            //Console.Write("Birici balinizi daxil edin : ");
            //int birinciBal = int.Parse(Console.ReadLine());

            //Console.Write("Ikinci balinizi daxil edin : ");
            //int ikinciBal = int.Parse(Console.ReadLine());

            //Console.Write("Ucuncu balinizi daxil edin : ");
            //int ucuncuBal = int.Parse(Console.ReadLine());

            //int ortalama = (birinciBal + ikinciBal + ucuncuBal) / 3;

            //if (ortalama > 80 && ortalama < 100)
            //{
            //    Console.WriteLine("Baliniz : A+ ");
            //}

            //else if (ortalama > 60 && ortalama < 80)
            //{
            //    Console.WriteLine("Baliniz : B ");
            //}

            //else if (ortalama > 40 && ortalama < 60) 
            //{
            //    Console.WriteLine("Baliniz : C ");
            //}


            #endregion End of daxil edilen 3 balin ortalamasi ve ekrana yazilmasi programi

            #region  mini ATM uygulamasi 

            Console.WriteLine("Hansi emeliyyati etmek isteyirsiniz ?");
            Console.WriteLine("Pul cixarmaq : 1 ");
            Console.WriteLine("Balansa baxmaq : 2 ");
            Console.WriteLine("Pul yatirmaq : 3 ");
            Console.WriteLine("Hesabdan cixis : q ");
            
            string secim = Console.ReadLine();
            int balans = 2000;
 
            //Bunlara ehtiyac olmur
            int minPul = 1; //Minimum yatirilan mebleg
            int maxPul = 20000; //Max yatirilan mebleg


            if (secim == "1")
            {
                Console.WriteLine("Cixarcaginiz meblegi daxil edin :");
                int mebleg = int.Parse(Console.ReadLine());
                //Console.WriteLine("Balans : " + (balans - mebleg));

                if (mebleg <= balans)
                {
                    Console.WriteLine("Balans : " + (balans - mebleg));

                }

                else if (mebleg > balans)
                {
                    Console.WriteLine("Kifayet qeder balans yoxdur");
                }

                else if (mebleg >= 1)
                {
                    Console.WriteLine("1 manat ve 20000manat arasinda mebleg secin");
                }

            }
            else if (secim == "2")
            {
                Console.WriteLine("Balansiniz : " + balans);
            }

            else if (secim == "3")
            {
                Console.WriteLine("Pulu daxil edin");
                int yatirilanPul = int.Parse(Console.ReadLine());
                Console.WriteLine("Yeni balansiniz : " + (balans + yatirilanPul));
            }

            else if (secim == "q")
            {
                Console.WriteLine("Hesabdan cixis olundu");
                Console.WriteLine("Xos gunler dileyirik");
            }

            else 
            {
                Console.WriteLine("Zehmet olmasa duzgun parametrleri daxil edin");
            }

           

           
            
            #endregion







































        }
    }
}