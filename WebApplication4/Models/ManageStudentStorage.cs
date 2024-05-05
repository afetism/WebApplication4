namespace WebApplication4.Models
{
    public class ManageStudentStorage : ILibrarianStorage
    {

        List<Librarian> Librarians {  get; set; }

        public ManageStudentStorage()
        {
            Librarians = new List<Librarian>()
            {
            new Librarian() {Id=1, Name="Xatire",Email="xatireresullu@gmail.com", HireDate=DateTime.Now},
            new Librarian() {Id=2,Name="Aynur",Email="seyfullazade@gmail.com", HireDate=DateTime.Now},
            new Librarian() {Id=3,Name="Afet", Email="ismayilova@gmail.com",HireDate=DateTime.Now}

            };
        }
        public Librarian GetLibrarian(int id)
        {
            return Librarians.SingleOrDefault(l => l.Id==id);
        }
        public List<Librarian> GetAllLibrarian()
        {
            return Librarians;
        }

       
    }
}
