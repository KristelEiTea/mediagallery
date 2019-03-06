using MediaGallery.Data;
using MediaGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGallery.Commands
{
    public class EditCommand : ICommand<PhotoEditModel>
    {
        private readonly GalleryContext _galleryContext;
        private readonly ApplicationDbContext _dataContext;

        public EditCommand(ApplicationDbContext dataContext,
                              GalleryContext galleryContext)
        {
            _dataContext = dataContext;
            _galleryContext = galleryContext;
        }

        public bool Execute(PhotoEditModel model)
        {
            var item = _dataContext.Photos.FirstOrDefault(i => i.Id == model.Id);

            item.Title = model.Title;

            _dataContext.SaveChanges();
            return true;
        }

        public bool Rollback()
        {
            return true;
        }

        public List<string> Validate(PhotoEditModel parameter)
        {
            return new List<string>();
        }
    }
}
