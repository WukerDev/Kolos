using System.ComponentModel.DataAnnotations;

namespace Wiktor_Kozakowski   
{

    public class Towar
    {
        [Key]
        public int IDTowar { get; set; }
        public string TowarNazwa { get; set; }
        public string Jednostka { get; set; }
        public int FK { get; set; }
    }
}