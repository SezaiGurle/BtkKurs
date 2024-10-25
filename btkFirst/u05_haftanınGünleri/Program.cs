// See https://aka.ms/new-console-template for more information
Console.WriteLine("Haftanin Kaçinci Günü?");
int day = Convert.ToInt32(Console.ReadLine());

switch(day){
    case 0: Console.WriteLine("Pazar"); break;
    case 1: Console.WriteLine("Pazartesi"); break;
    case 2: Console.WriteLine("Sali"); break;
    case 3: Console.WriteLine("Carsamba"); break;
    case 4: Console.WriteLine("Persembe"); break;
    case 5: Console.WriteLine("Cuma"); break;
    case 6: Console.WriteLine("Cumartesi"); break;
    default: Console.WriteLine("Hatali Day"); break;
}

switch(day)
{
    case 0:
    case 1:
    case 2:
    case 3: Console.WriteLine("Haftanin 1. yarisi");break;
    case 4:
    case 5:
    case 6: Console.WriteLine("Haftanin ikinci yarisi");break;
    default: Console.WriteLine("Hatali Day");break;
}