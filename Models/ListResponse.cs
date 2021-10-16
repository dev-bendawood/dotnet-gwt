using System.Collections.Generic;
namespace JwtExample.Models
{
    public class ListResponse<T>
    {
        public int length { get; set; }
        public IEnumerable<T> items { get; set; }

        public ListResponse() { }

        public ListResponse(int length, IEnumerable<T> items)
        {
            this.length = length;
            this.items = items;
        }
    }
}