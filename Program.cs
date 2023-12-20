﻿using D2_challenge;

int choice, data, k, x;

var list = new SingleLinkedList();

list.CreateList();

while (true)
{
    Console.WriteLine("1. Display list");
    Console.WriteLine("2. Count the number of nodes");
    Console.WriteLine("3. Search for an element");
    Console.WriteLine("4. Insert a node in empty list/ in the beginning of list");
    Console.WriteLine("5. Insert a node at the end of list");

    Console.WriteLine("6. Quit");

    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 6)
        break;

    switch (choice)
    {
        case 1:
            list.DisplayList();
            break;

        case 2:
            list.CountNodes();
            break;

        case 3:
            Console.Write("Enter the element to be searched: ");
            data = int.Parse(Console.ReadLine());
            list.Search(data);
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Exiting...");

}

