using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Book MyBook = new Book();

            Book MyBook2 = new Book();


            int MyBook1Count = Book.BookCount;
            int MyBook2Count = Book.BookCount;


            Page Page1 = new Page("Here is page1!");
            Page Page2 = new Page("And this is page 2!");





            MyBook.Pages.Add(Page1);
            MyBook.Pages.Add(Page2);

            MyBook.SetName("Object Oriented Programming");
            string bookname = MyBook.GetName();

            MyBook.BookName = "Book name!";



            MyBook.BookName = "Object Oriented PRogramming";

            string newBokName = MyBook.BookName;

            MyBook.Author = "Nathan Sawyer";

            string s = "";






        }




        public class Page
        {
            public string Contents;

            public Page(string contentsOfPage)
            {
                Contents = contentsOfPage;
            }
        }

        public class Book
        {
            public static int BookCount = 0;

            public List<Page> Pages = new List<Page>();

            private string Name;
            public string Author;

            public Book()
            {
                BookCount++;
            }

            public Book(string BookName, string BookAuthor)
            {
                BookCount++;

                Name = BookName;
                Author = BookAuthor;
            }

            public void SetName(string newName)
            {
                Name = newName;
            }

            public string GetName()
            {
                return Name;
            }

            public string BookName
            {
                get
                {
                    return Name;
                }
                set
                {
                    value = value + "!!!";

                    Name = value;
                }
            }


        }


    }
}
