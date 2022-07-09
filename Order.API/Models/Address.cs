using Microsoft.EntityFrameworkCore;

namespace Order.API.Models
{
    [Owned] //Owned: Bu class'a verilen özellikte farklı tablo açmayıp tanımlanan class içerisinde kolon olarak belirtir.
    public class Address
    {
        public string Line { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
    }
}
