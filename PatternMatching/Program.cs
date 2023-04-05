


//C# 7.0 Pattern Matching-Type-Pattern
object x = "Alihan";
if (x is string a)
{
    string _x = (string)x;
}



//C# 7.0 Pattern Matching-Constant Pattern
if (x is 123)
{
    Console.WriteLine( "x 123'tür ");
}
else if (x is int)
{
    Console.WriteLine("x is int dir");
}


// C# 7.0 Pattern Matching - Var Pattern
if (x is var verituru)
{
    Console.WriteLine(verituru);
}



//C# 9.0 Pattern Matching - Simple Type Pattern
/*
  
  string GetStudent(IStudent s) => s switch {
    SınıfAdi => "A sınıfı",
    Adi => "Alihan",
   not Soyadi => "Yeşil"
};


 */



// C# 9.0 Pattern Matching - Relational Pattern
int number = 50;
string result = (number) switch
{
    < 50 => " number sayısı 50 ' den  küçüktür", //" < " büyüktür kontrol
    > 50 => " number sayısı 50 ' den  büyüktür",  // ">" küçüktür kontrol
    var abc when abc == number => "x number a eşit", // var yerine int string vs. kullanılabilir
    not 51 => " 51 değildir " //  not 51 değilse  ekrana 51 değildir basar.
};
Console.WriteLine(result);


class Ogrenci
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }

    public string SinifAdi { get; set; }

    public void Deconstruct(out string name, out string surname)
    {
        name = Adi;
        surname = Soyadi;
    }




}