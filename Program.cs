﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan satu huruf (A-Z): ");
        char input = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        
        string vokal = "AIUEO";
        if (vokal.Contains(input))
        {
            Console.WriteLine("Huruf " + input + " merupakan huruf vokal.");
        }
        else if (char.IsLetter(input))
        {
            Console.WriteLine("Huruf " + input + " merupakan huruf konsonan.");
        }
        else
        {
            Console.WriteLine("Masukan tidak valid, harap masukkan huruf A-Z.");
        }
        
        int[] bilanganGenap = {2, 4, 6, 8, 10};
        Console.WriteLine("Daftar angka genap:");
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine("Angka genap " + (i + 1) + " : " + bilanganGenap[i]);
        }
    }
}
