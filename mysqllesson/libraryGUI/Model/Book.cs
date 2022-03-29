using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryGUI.Model
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
    }
}
