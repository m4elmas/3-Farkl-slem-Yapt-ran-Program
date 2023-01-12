using System.Collections;

Console.Clear();

Console.WriteLine("Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (1)");
Console.WriteLine();
Console.WriteLine("Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan program (2)");
Console.WriteLine();
Console.WriteLine("Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan program. (3)");
Console.WriteLine();
Console.Write("Yapmak İstediğiniz İşlem sayisini Giriniz : ");
int.TryParse(Console.ReadLine(),out int cikti);

Console.WriteLine();

if (cikti!=0)
{
    switch (cikti)
    {   
        case 1:
        Console.Clear();
        Birinci();
        break;

        case 2:
        Console.Clear();
        ikinci();
        break;
        
        case 3:
        Console.Clear();
        ucuncu();
        break;
        
        default:
        break;
    }

}














void Birinci(){

//Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız
//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

ArrayList asalsayi = new ArrayList();

ArrayList asalolmayansayi = new ArrayList();

int sayi;

int bolensayisi=0;

int ortalamahesapla=0;


Console.WriteLine("Lütfen 20 adet pozitif tam sayi giriniz");
for (int i = 1; i <= 20; i++)
{
    Console.Write(i+". sayiyi giriniz : ");
    string giris=Console.ReadLine();
    bool tamsayimi = int.TryParse(giris,out sayi);


    if (giris!="" && tamsayimi && sayi>0)
    {

     for (int j = 1; j <= sayi; j++)
       {

        if (sayi%j==0)
        {
            bolensayisi++;
        }
       }



        if (sayi>1 && bolensayisi==2)
        {
            asalsayi.Add(sayi);
        }

        else
        {
            asalolmayansayi.Add(sayi);
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Lütfen Geçerli bir pozitif tam sayi değeri giriniz!!!");
        i--;
        continue;
    }
    bolensayisi=0;
}

asalsayi.Sort();
asalsayi.Reverse();

asalolmayansayi.Sort();
asalolmayansayi.Reverse();


Console.WriteLine();
Console.WriteLine("Asal sayilar");
Console.WriteLine();

foreach (var item in asalsayi)
{
    Console.Write(item+" ");
}
Console.WriteLine();
Console.WriteLine("Asal olan sayilarin dizisinin toplam eleman sayisi : "+asalsayi.Count);

foreach (int item in asalsayi)
{
   
        ortalamahesapla+=item;
    
}
ortalamahesapla=ortalamahesapla/asalsayi.Count;

Console.WriteLine("Asal olan sayilarin dizisinin ortalamasi : "+ortalamahesapla);
ortalamahesapla=0;

Console.WriteLine();
Console.WriteLine("********************************");

Console.WriteLine("Asal olmayan sayilar");
Console.WriteLine();
foreach (var item in asalolmayansayi)
{
    Console.Write(item+" ");
}
Console.WriteLine();
Console.WriteLine("Asal olan sayilarin dizisinin toplam eleman sayisi : "+asalolmayansayi.Count);

foreach (int item in asalolmayansayi)
{
   
        ortalamahesapla+=item;
    
}
ortalamahesapla=ortalamahesapla/asalolmayansayi.Count;

Console.WriteLine("Asal olan sayilarin dizisinin ortalamasi : "+ortalamahesapla);
ortalamahesapla=0;



}




void ikinci(){
//Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

int[] sayilarim=new int[20];
int index=0;
int kucukortalama=0,buyukortalama=0;
Console.WriteLine("Lütfen 20 adet tam sayi giriniz");
for (int i = 1; i <= 20; i++)
{
    Console.Write(i+". sayiyi giriniz : ");
    string giris=Console.ReadLine();
    bool tamsayimi = int.TryParse(giris,out int sayi);


    if (giris!="")
    {
        sayilarim[index]=sayi;
        index++;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Lütfen Geçerli bir tam sayi değeri giriniz!!!");
        i--;
        continue;
    }
    
}
index=0;
Console.WriteLine();
Array.Sort(sayilarim);
Console.Write("En Küçük 3 sayi şunlardır : ");
for (int i = 0; i < 3; i++)
{
    Console.Write("|"+sayilarim[i]+"| ");
    kucukortalama+=sayilarim[i];
}
kucukortalama=kucukortalama/3;
Console.WriteLine();
Console.WriteLine("Kucuk 3 sayinin ortalaması şudur : "+kucukortalama);




Console.WriteLine();
Array.Reverse(sayilarim);
Console.Write("En Büyük 3 sayi şunlardır : ");
for (int i = 0; i < 3; i++)
{
    Console.Write("|"+sayilarim[i]+"| ");
    buyukortalama+=sayilarim[i];
}
buyukortalama=buyukortalama/3;
Console.WriteLine();
Console.WriteLine("Büyük 3 sayinin ortalaması şudur : "+buyukortalama);

Console.WriteLine("İki ortalamanın Toplamı şudur : "+(buyukortalama+kucukortalama));


}





void ucuncu(){
// Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.


Console.Write("Lütfen Bir Cümle Giriniz : ");

string cumle;
char[] sesliharfler={'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
List<char> cumledekisesliharfler=new List<char>();

cumle=Console.ReadLine();
Console.WriteLine();
if (cumle!="")
{
    foreach (char item in cumle)
    {
        if (sesliharfler.Contains(item))
        {
            cumledekisesliharfler.Add(item);
        }
    }
    
cumledekisesliharfler.Sort();

Console.WriteLine();
if (cumledekisesliharfler.Count==0)
{
    Console.WriteLine("Girdiğiniz Cümlede hiç sesli Harf Yoktur");
}
else
{
    Console.Write("Girdiğiniz Cümledeki sesli harfler şunlardır : ");
foreach (char item in cumledekisesliharfler)
{
    Console.Write(item+" ");
}
}


}
else
{
    Console.WriteLine();
    Console.WriteLine("Lütfen Geçerli Bir Cümle Giriniz");
}




}
