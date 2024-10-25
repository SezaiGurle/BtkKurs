Console.WriteLine("Bir metin girin:");
string metin = Console.ReadLine();
Console.WriteLine("\n\n");

int index = 0;
foreach(char c in metin){
    char c2 = c;
    if(index == 0)
    c2 = char.ToUpper(c);
    else if(metin[index-1] == ' ')
    c2 = char.ToUpper(c);
    Console.Write(c2 + " ");
    index++;
}