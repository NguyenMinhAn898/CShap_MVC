using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
        public int Type { get; set; }
        public bool Status { get; set; }
        public int Place { get; set; }
        public DateTime PublicDate { get; set; }

        public BlogModel() { }
        public BlogModel(int id, String title, String description, String imgUrl,int type, bool status, int place,DateTime publicDate)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageUrl = imgUrl;
            Type = type;
            Status = status;
            Place = place;
            PublicDate = publicDate;
        }
    }
}
