// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;


//Switch Expressions - Positional Patterns
int number = 50;

//Switch Expressions - Tuple Patterns
string name = "Alihan";
string result2 = (number,name) switch
{
     (15,"Alihan") => " Hello", //
    (25, "Alihan") => " asdsadas",  // 
    var x when x == (number,name) => "x number ve name  a eşit", // var yerine int string vs. kullanılabilir.
    (_, _) => " number sayısı 50 'ye eşittir "  //  "_" default kontrol
};
Console.WriteLine(result2);


//Switch Expressions - Tuple Patterns when Şartı
string result3 = (number, name) switch
{
    (15, "Alihan") => " Hello", //
    (25, "Alihan") => " asdsadas",  // 
    var x when x.number + 2 ==52 && x.name=="Alihan"  => "x number ve name  a eşit", // var yerine int string vs. kullanılabilir.
    (_, _) => " number sayısı 50 'ye eşittir "  //  "_" default kontrol
};
Console.WriteLine(result3);


//Switch Expressions - Positional Patterns 
Ogrenci std = new Ogrenci
{
    Adi = "Alihan",
    Soyadi = "Yeşil",
    SinifAdi = "A sınıfı"
};

var result4 =std switch
{
    ("Alihan", "Yeşil") => " Alihan Yeşil", 
    ("Abdulbaki", "Yeşil") when 3==5  => "Abdulbaki Yeşil", //when ile koşul kontrolü yapılabilir.
    var nesne when nesne.Adi == "Yeşil" && nesne.Soyadi == "Alihan" => "Adı ve Soyadı Doğru", // var yerine int string vs. kullanılabilir.
    (_, _) => " hiçbiri ",  //  "_" default kontrol
    _=> "hiçbiri"
};
Console.WriteLine(result4);

//Switch Expressions - Property Patterns

string  sinif = std switch
{
    { SinifAdi: "A"} => " A SINIFI", 
    { SinifAdi: "B" } => "B SINIFI ",
    { SinifAdi: "C" } => "C SINIFI", 
    _ => "Sınıf Mevcut Değil "
};
//Switch Expressions - Property Patterns when koşul

string sinifkosul = std switch
{
    { SinifAdi: "A" } => " A SINIFI",
    var x when x.SinifAdi == "B" => "B SINIFI ",
    { SinifAdi: "C" } when !true => "C SINIFI",
   var x =>"sınıf yok" // ya da _ => 0
};
Console.WriteLine(sinifkosul);
class Ogrenci
{
    public string Adi { get; set;}
    public string Soyadi { get; set; }

    public string SinifAdi { get; set; }

  public void Deconstruct(out string name,out string  surname)
    {
        name = Adi;
        surname = Soyadi;
    }

   


}


