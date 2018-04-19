using System;
using System.Collections.Generic;
using System.IO;

namespace Abstract_Class
{
    abstract class Book
    {
        protected String title;
        protected  String author;
        
        public Book(String t,String a){
            title=t;
            author=a;
        }
        public abstract void display();
    }

    class MyBook : Book
    {
        int price = 0;

        public MyBook(String title, String author, int price) : base(title, author){
            this.price = price;
        }
    
        public override void display() {
            Console.WriteLine("Title: {0}",title);
            Console.WriteLine("Author: {0}",author);
            Console.WriteLine("Price: {0}",price);
        }
    }

    class Program
    {
        static void Main(String[] args) {

            String title=Console.ReadLine();
            String author=Console.ReadLine();
            int price=Int32.Parse(Console.ReadLine());
            Book new_novel=new MyBook(title,author,price);
            new_novel.display();
        }
    }
}
