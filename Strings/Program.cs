//Intro();
string sentence = "My name is Engin Demiroğ";

var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Derin Demiroğ";

bool result3 = sentence.EndsWith("ğ"); //sonuç bool şeklinde döndürülür
bool result4 = sentence.StartsWith("My name");

var result5 = sentence.IndexOf("name");//bulamazsa -1 döndürür
var result6 = sentence.IndexOf(" "); //bulduğu ilk boşluğu yazar sonra devam etmez
var result7 = sentence.LastIndexOf(" "); //aramaya sondan başlar ilk bulduğu boşluğu yazar
var result8 = sentence.Insert(0,"Hello, ");
var result9 = sentence.Substring(3,4); //3.karakterden itibaren 4 tane al
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(2,5); //2den itibaren 5 karekter uçur
Console.WriteLine(result13);
Console.ReadLine();

static void Intro()
{
    string city = "Ankara";
    //Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";

    Console.WriteLine(String.Format("{0} [1}", city, city2));
}