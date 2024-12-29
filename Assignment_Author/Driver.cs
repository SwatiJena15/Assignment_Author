using System;

namespace Assignment_Author
{
    public class Author
    {
        public string AuthorName { get; set; }

        public Author(string name)
        {
            AuthorName = name;
        }
    }


    public class Work
    {
        public string BookTitle { get; set; }

        public Work(string title)
        {
            BookTitle = title;
        }
    }



    public class Driver
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter Author Name:");
            string authorName = Console.ReadLine();


            Author author = new Author(authorName);
            Console.WriteLine($"Comparing Author name from Author class__________________");
            Console.WriteLine($"Is {author.AuthorName} Author? : {author is Author}");


            Work work = new Work("Sample Book");
            Console.WriteLine($"Comparing book1 from Author class__________________");
            Console.WriteLine($"Is {work.BookTitle} belongs to class Author? : {work is Author}");


            author = null;
            Console.WriteLine($"Taking the author name as null__________________");
            Console.WriteLine($"Is {authorName} Author? : {author is Author}");
        }
    }
}
