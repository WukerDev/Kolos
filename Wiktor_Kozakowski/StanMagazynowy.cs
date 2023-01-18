using System.ComponentModel.DataAnnotations;

namespace Wiktor_Kozakowski
{
    public class StanMagazynowy
    {
        [Key]
        public int IDStan { get; set; }
        public int Ilosc { get; set; }
    }
}