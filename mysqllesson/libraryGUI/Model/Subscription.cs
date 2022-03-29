using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryGUI.Model
{
    internal class Subscription
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public string ReaderName { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public DateTime TakingDate { get; set; }
        public DateTime BringDate { get; set; }
        public bool IsReturn { get; set; }
    }
}
