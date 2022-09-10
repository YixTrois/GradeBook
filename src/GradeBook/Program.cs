﻿using System;
using System.Collections.Generic;

namespace GradeBook
{   
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new InMemoryBook("Yixing's Grade Book");
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);
            book.AddGrade(89.10);
            book.AddGrade(90.15);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();
            Console.WriteLine(InMemoryBook.CATEGORY);
            Console.WriteLine($"The book name is {book.Name}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true) {
                Console.WriteLine("Enter your grade or q to exit");
                var input = Console.ReadLine();
                if (input == "q") {
                    break;
                } 
                try {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                } catch (ArgumentException ex){
                    Console.WriteLine(ex.Message);
                } catch (FormatException ex) {
                    Console.WriteLine(ex.Message);
                } finally {
                    Console.WriteLine("**");
                }
            }
        }




        static void OnGradeAdded(object sender, EventArgs e) {
            Console.WriteLine("a grade has been added");
        }
    }
}
