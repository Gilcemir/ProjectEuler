using System;
using Project;

static string Menu()
{
    Console.WriteLine();
    Console.WriteLine(@"Enter the ID of the problem (1, 2, 3 etc): (X to exit!)");

    Console.WriteLine();

    return Console.ReadLine().ToLower();
}


string menu = Menu();

while (menu.ToLower() != "x")
{
    switch (menu)
    {
        case "1":
            pe001.Get();
            break;
        case "2":
            pe002.Get();
            break;
        case "3":
            pe003.Get();
            break;
        case "4":
            pe004.Get();
            break;
        case "5":
            pe005.Get();
            break;
        case "6":
            pe006.Get();
            break;
        case "7":
            pe007.Get();
            break;
        case "8":
            pe008.Get();
            break;
        case "9":
            pe009.Get();
            break;
        case "10":
            pe010.Get();
            break;
        case "11":
            pe011.Get();
            break;
        case "12":
            pe012.Get();
            break;
        case "13":
            pe013.Get();
            break;
        case "14":
            pe014.Get();
            break;            
        default:
            Console.WriteLine("Not implemented yet.");
            break;
    }

    menu = Menu();
}
