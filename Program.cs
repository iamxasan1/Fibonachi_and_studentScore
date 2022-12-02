﻿using System;
#region talabalar bahosi (input, update, list)

// Console.Write("iltimos guruhdagi talabalar sonini kiriting");
// int talabalarSoni = Convert.ToInt32(Console.ReadLine());
// string[] ism = new string[talabalarSoni];
// int[] baho = new int[talabalarSoni];
// Console.Clear();
// for(int i = 0; i < talabalarSoni; i++)
// {
//     Console.WriteLine($"iltimos {i+1} chi talaba ismini kiriting");
//     ism[i] = Convert.ToString(Console.ReadLine());
//     Console.Clear();
//     Console.WriteLine($"iltimos {i+1} chi talaba bahosini kiriting");
//     baho[i] = Convert.ToInt32(Console.ReadLine());
//     Console.Clear();
// }

// Console.WriteLine("iltimos kerakli talaba ismini kiriting!!");
// string talabaIsmi = Console.ReadLine();
// for(int j = 0; j < talabalarSoni; j++)
// {
//     if(ism[j] == talabaIsmi)
//     {
//         Console.Write($"{ism[j]} talabani o`zgargan bahosini kiriting: ");
//         int yangiBaho = Convert.ToInt32(Console.ReadLine());
//         baho[j] = yangiBaho;
//     }
// }
// System.Console.WriteLine("talabalarning bahosi o`zgargan holatdagi ro`yhati:");
// for(int a = 0; a < talabalarSoni; a++)
// {
//     Console.WriteLine($"{ism[a]} ning bahosi: {baho[a]}");
// }

#endregion

#region fibonachi sonlari
void fibonachi()
{   
    Console.WriteLine("iltimos fibonachi chegarasini kiriting: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    int[] fibArray = new int [x];
    int result = 0;
    fibArray[0] = 0;
    fibArray[1] = 1;
    
    for(int i = 2; i < x; i++)
    {
        result = fibArray[i-1] + fibArray[i-2];
        fibArray[i] = result;
    }

    for(int j = 1; j <= x; j++)
    {
        System.Console.WriteLine($"fibonachining {j} chi elementi {fibArray[j-1]} ga teng");
    }
};

fibonachi();
#endregion























/* Bir xil tipdagi elementlarning to`plamiga massiv
deyiladi .Massivlarni e`lon(declare) qilishning bir necha 
yo`li bor. Bularning ichida eng osoni 

1)     string[] cars;

usulida e`lon qilishdir. Bus usulda massiv nechta
elementdan tashkil topgani va massivning elementlari oldindan
kiritilmaydi. Faqatgina massiv elementlarining tipi kiritilib 
o`tiladi. 

2) string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

bu usulda biz ichida elementlari mavjud bo`lgan massiv yaratamiz.
Bunda massiv nomidan so`ng " = " belgisini qo`yib " { }"
belgisining ichiga vergullar bilan ajratib yozib , kiritib o`tamiz.

*/