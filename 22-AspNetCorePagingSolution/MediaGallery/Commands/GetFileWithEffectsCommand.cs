using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using SixLabors.ImageSharp.Processing;
using MediaGallery.Commands;
using MediaGallery.Data;
using MediaGallery.FileSystem;
using MediaGallery.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.PixelFormats;
using ExifLibrary;
using Microsoft.AspNetCore.Authorization;
using MediaGallery.Controllers;

namespace MediaGallery.Commands
{
    public class GetFileWithEffectsCommand : ICommand<PicWithEffectModel>
    {
        private readonly IFileClient _fileClient;
        private readonly GalleryContext _galleryContext;
        private readonly ApplicationDbContext _dataContext;
        private readonly ILogger<HomeController> _logger;

        public GetFileWithEffectsCommand(ApplicationDbContext dataContext,
                              IHostingEnvironment host,
                              IFileClient fileClient,
                              ILogger<HomeController> logger,
                              GalleryContext galleryContext)
        {
            _dataContext = dataContext;
            _galleryContext = galleryContext;
            _fileClient = fileClient;
            _logger = logger;
        }

        //public GetFileWithEffectsCommand()
        //{
            
        //}

        public bool Execute(PicWithEffectModel model)
        {
            var item = _dataContext.Items
                                  .Include(p => p.ParentFolder)
                                  .FirstOrDefault(i => i.Id == model.Id);

            var fileItem = (Photo)item;
            var folder = fileItem.ParentFolder;
            var path = fileItem.FileName;
            if (folder != null)
            {
                path = _galleryContext.GetFolderPath(folder.Id, fileItem.FileName);
            }

            var fileName = fileItem.FileName;
            var effect = model.Effect;
            try
            {
                IImageFormat format;
                using (var fileStream = _fileClient.GetFile(path))
                using (var image = Image.Load(fileStream, out format))
                {
                    Image<Rgba32> imageWithEffect;

                    if (effect == "BlackWhite")
                    {
                        imageWithEffect = image.Clone(ctx => ctx.BlackWhite());
                    }
                    else if (effect == "OilPaint")
                    {
                        imageWithEffect = image.Clone(ctx => ctx.OilPaint());
                    }
                    else if (effect == "Sepia")
                    {
                        imageWithEffect = image.Clone(ctx => ctx.Sepia());
                    }
                    else if (effect == "Blur")
                    {
                        imageWithEffect = image.Clone(ctx => ctx.GaussianBlur());
                    }
                    else if (effect == "Sharpen")
                    {
                        imageWithEffect = image.Clone(ctx => ctx.GaussianSharpen());
                    }
                    else if (effect == "Glow")
                    {
                        imageWithEffect = image.Clone(ctx => ctx.Glow());
                    }
                    else if (effect == "Invert")
                    {
                        imageWithEffect = image.Clone(ctx => ctx.Invert());
                    }
                    else
                    {
                        imageWithEffect = image;
                    }
                    imageWithEffect.Save(model.outStream, format);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
            }
            return true;
        }

        public bool Rollback()
        {
            return true;
        }

        public List<string> Validate(PicWithEffectModel parameter)
        {
            return new List<string>();
        }
    }
}
