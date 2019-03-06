using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGallery.Models
{
    public class PicWithEffectModel
    {
        public int Id { get; set; }
        public string Effect { get; set; }
        public Stream outStream { get; set; }
    }
}
