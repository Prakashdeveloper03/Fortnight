using System;
using System.Collections.Generic;
using System.IO;

abstract class Book {    
    protected String title;
    protected  String author;
    public Book(String t,String a){
        title = t;
        author = a;
    }
    public abstract void display();
}

class MyBook : Book {
    public int Price {
        get;
        set;
    }
    
    public MyBook(string title, string author, int price) : base(title, author){
        this.Price = price;
    }
    
    public override void display(){
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Author: {this.author}");
        Console.WriteLine($"Price: {this.Price}");
    }
}

class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}