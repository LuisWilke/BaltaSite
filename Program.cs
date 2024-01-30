using System;
using baltasite.ContentContext;

namespace baltasite
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de impressão");
            
            var course  = new Course();
            course.Level = ContentContext.Enums.EcontentLevel.Beginner;
            foreach (var item in course.Modules)
            {

            }
        }
    }
}