﻿using System;
using Project;

static string Menu()
{
    Console.WriteLine();
    Console.WriteLine(@"Enter the ID of the problem (1, 2, 3 etc): (X to exit!)");

    Console.WriteLine();

    return Console.ReadLine().ToLower();
}


string menu = Menu();

while(menu.ToLower() != "x"){
    switch(menu){
        case "1":
        p001.Get();
        break;
        case "2":
        p002.Get();
        break;
        case "3":
        p003.Get();
        break;
        case "4":
        p004.Get();
        break;
        case "5":
        p005.Get();
        break;               
        case "6":
        p006.Get();
        break;
        case "7":
        p007.Get();
        break;          
        case "8":
        p008.Get();
        break;
        case "9":
        p009.Get();
        break;          
        case "10":
        p010.Get();
        break;
        case "11":
        p011.Get();
        break;            
        default:
        Console.WriteLine("Not implemented yet.");
        break;
    }

    menu = Menu();
}
