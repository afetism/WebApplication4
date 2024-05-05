namespace WebApplication4.Models;
    public interface ILibrarianStorage
    {
    Librarian GetLibrarian (int id);
    List<Librarian> GetAllLibrarian();
     }

