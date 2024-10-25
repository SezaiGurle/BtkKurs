Console.Write("1. Vize Notu:");
double midterm1 = Convert.ToDouble(Console.ReadLine());

Console.Write("2. Vize Notu:");
double midterm2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Final Notu:");
double final = Convert.ToDouble(Console.ReadLine());

double sonuc = midterm1*0.3 + midterm2*0.3 + final*0.4;

Console.WriteLine("Ortalama =" + sonuc);

Console.Write("Sonuc=" + (sonuc >=70));
