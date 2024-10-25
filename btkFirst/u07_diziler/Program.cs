int [] sayilar = {1,2,3,4,5};

foreach(int s in sayilar){
Console.WriteLine($"{s},");
}

int [] sayilar2 = new int [5];

sayilar2[0] = 3;
Console.WriteLine("\nDizinin 1. indeksteki elemani kaç olsun?");
sayilar2[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n2.dizinin elemanlari:");

foreach(int s in sayilar2){
Console.WriteLine($"{s},");
}