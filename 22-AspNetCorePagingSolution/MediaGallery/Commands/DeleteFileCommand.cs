using MediaGallery.Data;
using MediaGallery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MediaGallery.Commands
{
    public class DeleteFileCommand : ICommand<DeleteFileModel>
    {
        private readonly GalleryContext _galleryContext;
        private readonly ApplicationDbContext _dataContext;

        public DeleteFileCommand(ApplicationDbContext dataContext,
                              GalleryContext galleryContext)
        {
            _dataContext = dataContext;
            _galleryContext = galleryContext;
        }

        public bool Execute(DeleteFileModel model)
        {
            var file = _dataContext.Photos
                                   .Include(p => p.ParentFolder)
                                   .FirstOrDefault(p => p.Id == model.Id);

            var parentId = file.ParentFolder?.Id;

            _dataContext.Photos.Remove(file);
            _dataContext.SaveChanges();

            return true;
        }

        public bool Rollback()
        {
            return true;
        }

        public List<string> Validate(DeleteFileModel parameter)
        {
            return new List<string>();
        }
    }
}
