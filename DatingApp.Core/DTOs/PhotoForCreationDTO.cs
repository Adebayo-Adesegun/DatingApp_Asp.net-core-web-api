using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace DatingApp.Core.DTOs
{
    public class PhotoForCreationDTO
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public string  PublicID { get; set; }
    }
}
