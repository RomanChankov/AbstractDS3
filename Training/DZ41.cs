using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.GC;
using static System.Exception;
using static System.Console;
using System.Drawing;
using System.Threading;

namespace InterfacesWPU221
{

    class Book
    {

        public string Autor { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Autor}: {Name}\n";
        }
    }
    class BookStore
    {
        private List<Book> _books = new List<Book>();
        private const int MAX_BOOKS = 100;

        public Book this[string number]
        {
            get
            {
                var book = _books.FirstOrDefault(c => c.Name == number);
                return book;
            }

        }
        public Book this[int index]
        {
            get
            {
                if (index < _books.Count)
                {
                    return _books[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index < _books.Count)
                {
                    _books[index] = value;
                }
            }
        }

        public int Count => _books.Count; //Только на чтение
        public string Name { get; set; }
        public int Add(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Книг нет");
            }
            if (_books.Count < MAX_BOOKS)
            {
                _books.Add(book);
                return _books.Count - 1;
            }
            return -1;
        }
        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is null or empty");
            }
            var book = _books.FirstOrDefault(c => c.Name == number);
            if (book != null)
            {
                _books.Remove(book);
            }
        }
    }

    //class BookStore
    //{
    //    Book[] bookArr;
    //    public BookStore(int size)
    //    {
    //        bookArr = new Book[size];
    //    }
    //    public int Lenght
    //    {
    //        get { return bookArr.Length; }
    //    }
    //    public Book this[int index]
    //    {
    //        get
    //        {
    //            if (index >= 0&&index<bookArr.Length)
    //            {
    //            return bookArr[index];
    //            }
    //            throw new IndexOutOfRangeException();
    //        }
    //        set
    //        {
    //            bookArr[index] = value;
    //        }
    //    }
    //}

    class Program
    {

        static void Main(string[] args)
        {
            var books = new List<Book>()
            {
                new Book(){Autor="Булгаков",Name="Мастер и Маргарита"},
                new Book(){Autor= "Гоголь",Name="Мертвые души"},
                new Book() { Autor = "Пушкин", Name = "Евгений Онегин" }
            };
            var bookstore = new BookStore();
            foreach (var book in books)
            {
                bookstore.Add(book);
            }
            WriteLine(bookstore["Мертвые души"].Name);
            WriteLine(bookstore["Метель"]?.Name);

            WriteLine("Введите новое название книги");
            var num=ReadLine();

            bookstore[1]=new Book() {Autor="Толстой",Name=num };
            WriteLine(bookstore[1]);   

            //BookStore book=new BookStore(10);
            //book[0] = new Book { Autor = "Булгаков", Name = "Мастер и Маргарита" };
            //book[1] = new Book { Autor = "Гоголь", Name = "Мертвые души" };
            //book[2] = new Book { Autor = "Пушкин", Name = "Евгений Онегин" };


            //Book nameBook = book[3];
            //WriteLine(nameBook.Name);

            //try
            //{
            //    for (int i = 0; i < book.Lenght; i++)
            //    {
            //        WriteLine(book[i]);
            //    }
            //}
            //catch (Exception e)
            //{
            //    WriteLine(e.Message);
            //}


        }
    }
}
