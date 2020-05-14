using System.Collections.Generic;

namespace libraryapi.DB
{
  public static class FakeDB
  {
    public static List<Book> Books = new List<Book>()
    {
      new Book("To Kill A Mockingbird", "Harper Lee", 7),
      new Book("The Great Gatsby", "F. Scott Fitzgerald", 10),
      new Book("Lord of the Flies", "William Golding", 14)
    };
  }
}