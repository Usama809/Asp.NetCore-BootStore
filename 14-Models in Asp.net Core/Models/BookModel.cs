using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using _14_Models_in_Asp.net_Core.Enums;
using _14_Models_in_Asp.net_Core.Data;
using _14_Models_in_Asp.net_Core.Helpers;
using Microsoft.AspNetCore.Http;

namespace _14_Models_in_Asp.net_Core.Models
{
    public class BookModel
    {

        public int Id { get; set; }
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage ="Please enter the title of your Book")]
        //[MyCustomValidation(Text ="Azure")]
        public string Title { get; set; }
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage ="Please enter the Auhor name")]
        public string Author { get; set; }
        [StringLength(500)]

        public string Description { get; set; }
        public string Category { get; set; }
        //[Required(ErrorMessage ="Please choose the Language of your book")]
        public int LanguageId { get; set; }
        public string Language { get; set; }

        [Required (ErrorMessage ="Please enter the Total Pages")]
        [Display(Name ="Total Pages of Book")]
        public int? TotalPages { get; set; }
        [Display(Name = "Choose the cover photo of your book")]
        [Required]
        public IFormFile CoverPhoto { get; set; }

        public string CoverImageUrl { get; set; }

        [Display(Name = "Choose the gallery Images of your book")]
        [Required]
        public IFormFileCollection GalleryFiles { get; set; }
        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "Uplaod your book in Pdf Format")]
        [Required]
        public IFormFile BookPdf { get; set; }
        //public List<IFormFile> Images { get; set; }

        public string BookPdfUrl{ get; set; }

    }
}
