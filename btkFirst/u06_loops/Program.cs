for(int i=0; i<10; i++){
    Console.WriteLine('*');
}

int k = 0;
while(k<10){
    Console.WriteLine(k + ' ');
    ++k;
}


﻿string girilenPinKodu="";
int deneme=1;
do
{
    Console.WriteLine($"PİN Kodunu Girin({deneme}.deneme):");
    girilenPinKodu = Console.ReadLine();
    deneme++;
} while (girilenPinKodu != "1234");