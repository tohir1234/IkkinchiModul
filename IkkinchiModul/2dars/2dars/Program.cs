namespace _2dars;


internal class Program
{
   

    static List<Book> Books = new List<Book>();
    static void Main(string[] args)
    {
        DataSeed();


        var books = GetExpensiveBooksThenMinPrice(100);
        Console.WriteLine(books);




    }

    //static List<Book> GetExpensiveBooksThenMinPrice(decimal minPrice)
    //{
    //    var expensiveBooks = new List<Book>();

    //    foreach (var book in Books)
    //    {
    //        if (book.Price > minPrice)
    //        {
    //            expensiveBooks.Add(book);
    //        }
    //    }

    //    return expensiveBooks;
    //}
    static List<Book> GetExpensiveBooksThenMinPrice(int  minPageCount)
    {
        var expensiveBooks = new List<Book>();

        foreach (var book in Books)
        {
            if (book.PageCount > minPageCount)
            {
                expensiveBooks.Add(book);
            }
        }

        return expensiveBooks;
    }




    static List<Book> GetExpensiveBooksThenMinPrice(decimal minPrice)
    {
        var expensiveBooks = new List<Book>();

        foreach (var book in Books)
        {
            if (book.Price > minPrice)
            {
                expensiveBooks.Add(book);
            }
        }

        return expensiveBooks;
    }



    static Book GetMaxPricedBook()
    {
        Book book = Books[0];

        foreach (var b in Books)
        {
            if (book.PageCount < b.PageCount)
            {
                book = b;
            }
        }

        return book;
    }









    //static Book GetMaxPricedBook()
    //{
    //    Book book = Books[0];

    //    foreach (var b in Books)
    //    {
    //        if (book.Price < b.Price)
    //        {
    //            book = b;
    //        }
    //    }

    //    return book;
    //}


    static void DataSeed()
    {
        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            Price = 10.99m,
            Description = "A novel set in the Jazz Age that tells the story of Jay Gatsby's unrequited love for Daisy Buchanan.",
            Created = DateTime.Now,
            Genre = "Classic",
            PageCount = 180
        });

        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Sariq Devni Minib",
            Author = "Xudoyberdi To'xtaboyev",
            Price = 5.99m,
            Description = "Legenda",
            Created = DateTime.Now,
            Genre = "Fantasy",
            PageCount = 270
        });

        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Harry Poter",
            Author = "Opa",
            Price = 15.99m,
            Description = "Legenda 2",
            Created = DateTime.Now,
            Genre = "Fantasy",
            PageCount = 870
        });
    }
}

