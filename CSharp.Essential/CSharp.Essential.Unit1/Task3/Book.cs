using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit1
{
    class Book
    {
        private Title title = null;
        private Author author = null;
        private Content content = null;

        void InitializeBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }

        public Book(string title)
        {
            InitializeBook();
            this.title.TitleOfBook = title;
        }

        public string Title
        {
            set { this.title.TitleOfBook = value; }
        }

        public string Author
        {
            set { this.author.BookAuthor = value; }
        }

        public string Content
        {
            set { this.content.BookContent = value; }
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }
    }

    class Title
    {
        private string _title;

        public string TitleOfBook
        {
            set { this._title = value; }
            private get
            {
                if (_title != null)
                    return _title;
                else
                    return "Заголовок отсутствует.";
            }
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(TitleOfBook);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class Author
    {
        private string _author;

        public string BookAuthor
        {
            private get
            {
                if (_author != null)
                    return _author;
                else
                    return "Автор отсутствует.";
            }
            set { _author = value; }
        }



        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(BookAuthor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class Content
    {
        private string _content;

        public string BookContent
        {
            private get
            {
                if (_content != null)
                    return _content;
                else
                    return "Тело документа отсутствует.";
            }
            set { _content = value; }
        }



        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(BookContent);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
