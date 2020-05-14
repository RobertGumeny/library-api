using System.Collections.Generic;

namespace libraryapi.DB
{
  public static class FakeDB
  {

    public static List<Author> Authors = new List<Author>()
    {
      new Author("Harper Lee"),
      new Author("F. Scott Fitzgerald"),
      new Author("William Golding"),
      new Author("Tom Clancy"),
      new Author("George Orwell")
    };
    public static List<Book> Books = new List<Book>()
    {
      new Book("To Kill A Mockingbird", Authors[0].Id, 10)
    };

    public static List<Movie> Movies = new List<Movie>()
    {
      new Movie("Clear and Present Danger", "Agent Jack Ryan (Harrison Ford) becomes acting deputy director of the CIA when Admiral Greer (James Earl Jones) is diagnosed with cancer.", "VHS", 2),
      new Movie("Avatar", "On the lush alien world of Pandora live the Na'vi, beings who appear primitive but are highly evolved.", "DVD", 3)
    };
  }
}