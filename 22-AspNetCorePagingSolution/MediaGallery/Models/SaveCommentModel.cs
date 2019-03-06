using MediaGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGallery.Models
{
    public class SaveCommentModel
    {
        public Comment comment { get; set; }
        public int mediaItemId { get; set; }
        public System.Security.Claims.ClaimsPrincipal User { get; set; }
    }
}
