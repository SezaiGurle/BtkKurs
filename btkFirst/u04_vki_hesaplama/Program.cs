Console.Write("Boyunuz(cm)?");
double height = double.Parse(Console.ReadLine());

Console.Write("Kilonuz(kg)?");
double weight = Convert.ToDouble(Console.ReadLine());

//vki = kilo kg / (boy m) karesi
double height2 = height*0.01;
double vki = weight / (height2 * height2);

Console.WriteLine($"Vki Değeri = {vki:f2}");

if(vki <18.5){
    Console.WriteLine("Zayif");
}else if(vki>=18.5 && vki<25){
    Console.WriteLine("Normal");
}else if(vki>=25 && vki<38){
    Console.WriteLine("Kilolu");
}else if(vki>=30){
    Console.WriteLine("OBEZ");
}
