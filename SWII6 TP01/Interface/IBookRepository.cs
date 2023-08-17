using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;

// Marcelo Modesto de Lima Junior CB3015823
// Bruna Helena Silva Santos CB3016111

namespace TP01.Interface
{
    public interface IBookRepository
    {
        ICollection<Book> getAll();
        void add(Book book);
    }
}
