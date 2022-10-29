using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Photo
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public int ApplicationUserId { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public static implicit operator Photo(List<Photo> v)
        {
            throw new NotImplementedException();
        }
    }
}
