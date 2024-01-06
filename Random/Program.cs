// See https://aka.ms/new-console-template for more information


// c# dilinde random sayı üretmek isteyebiliriz. Random sayı üretme işini Random ile yapabiliriz


Random rnd=new Random();

//  0 ile 10000 arası sayı üretecek
int randomSayi = rnd.Next(10000);

// her hangi bir sınır vermezseniz int değerinin sınıfları çerçevesinde değerler üretecektir.
int randomSayi1 = rnd.Next();

// 10 ile 20 arasında bir random sayı üretecektir
int randomSayi2 = rnd.Next(10, 20);

Console.WriteLine(randomSayi);



Console.WriteLine(randomSayi1);

Console.WriteLine(randomSayi2);
