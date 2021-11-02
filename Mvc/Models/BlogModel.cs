using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class BlogModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Description not null")]
        public String Title { get; set; }
        [Required(ErrorMessage = "Description not null")]
        public String Short_Description { get; set; }
        [Required(ErrorMessage = "Description not null")]
        public String Description { get; set; }
        public String ImageUrl { get; set; }
        public String Place { get; set; }
        public int Category_Id { get; set; }
        [Required]
        public DateTime? Public_Date { get; set; }

        public String Public_Date_Str
        {
            get {
                return Public_Date != null ? Public_Date.Value.ToString("MM/dd/yyyy") : "Chưa public";
            }
        }
        public bool Status { get; set; }
        public bool Is_active { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Created_at { get; set; }

        /// <summary>
        /// Contructor
        /// </summary>
        public BlogModel() { }
        public BlogModel(int id, String title, String description, String imgUrl,int category_id, bool is_active, String place,DateTime publicDate)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageUrl = imgUrl;
            Category_Id = category_id;
            Is_active = is_active;
            Place = place;
            Public_Date = publicDate;
        }
    }
}
