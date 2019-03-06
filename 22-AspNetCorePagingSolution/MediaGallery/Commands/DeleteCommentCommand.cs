using MediaGallery.Data;
using MediaGallery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGallery.Commands
{
    public class DeleteCommentCommand : ICommand<DeleteCommentModel>
    {
        private readonly GalleryContext _galleryContext;
        private readonly ApplicationDbContext _dataContext;

        public DeleteCommentCommand(ApplicationDbContext dataContext,
                              GalleryContext galleryContext)
        {
            _dataContext = dataContext;
            _galleryContext = galleryContext;
        }

        public bool Execute(DeleteCommentModel model)
        {
            var comment = _dataContext.Comments
                                      .Include(c => c.MediaItem)
                                      .FirstOrDefault(c => c.Id == model.Id);

            _dataContext.Comments.Remove(comment);
            _dataContext.SaveChanges();
            return true;
        }

        public bool Rollback()
        {
            return true;
        }

        public List<string> Validate(DeleteCommentModel parameter)
        {
            return new List<string>();
        }
    }
}
