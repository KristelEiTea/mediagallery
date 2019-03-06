using MediaGallery.Data;
using MediaGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaGallery.Commands;
using MediaGallery.FileSystem;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaGallery.Commands
{
    public class SaveCommentCommand : ICommand<SaveCommentModel>
    {
        private readonly GalleryContext _galleryContext;
        private readonly ApplicationDbContext _dataContext;

        public SaveCommentCommand(ApplicationDbContext dataContext,
                              GalleryContext galleryContext)
        {
            _dataContext = dataContext;
            _galleryContext = galleryContext;
        }

        public bool Execute(SaveCommentModel model)
        {
            model.comment.MediaItem = _dataContext.Items.FirstOrDefault(i => i.Id == model.mediaItemId);
            model.comment.Time = DateTime.Now;
            model.comment.User = _dataContext.Users.FirstOrDefault(u => u.UserName == model.User.Identity.Name);

            _dataContext.Comments.Add(model.comment);
            _dataContext.SaveChanges();
            return true;
        }

        public bool Rollback()
        {
            return true;
        }

        public List<string> Validate(SaveCommentModel parameter)
        {
            return new List<string>();
        }
    }
}
