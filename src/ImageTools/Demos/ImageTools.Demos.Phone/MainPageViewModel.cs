// ===============================================================================
// MainPageViewModel.cs
// .NET Image Tools
// ===============================================================================
// Copyright (c) .NET Image Tools Development Group. 
// All rights reserved.
// ===============================================================================

using System;
using ImageTools.IO;
using ImageTools.IO.Gif;

namespace ImageTools.Demos.Phone
{
    /// <summary>
    /// Simple view model that holds a property to the image source.
    /// </summary>
    public sealed class MainPageViewModel
    {
        //private readonly Uri _imageSource = new Uri("Images/Building.png", UriKind.Relative);
        //private readonly Uri _imageSource = new Uri("Images/HidesInbushes.gif", UriKind.Relative);
        //private readonly Uri _imageSource = new Uri("Images/Nelson_GIF_by_sambu.gif", UriKind.Relative);

        // private readonly Uri _imageSource = new Uri("Images/florida.gif", UriKind.Relative);
        private readonly Uri _imageSource = new Uri("http://i153.photobucket.com/albums/s235/revmyspace2/graphics/entertain/rap/000flo_rida.gif", UriKind.Absolute);
        //private readonly Uri _imageSource = new Uri("http://i153.photobucket.com/albums/s235/revmyspace2/graphics/entertain/rap/000flo_rida.gif", UriKind.Absolute);
        //private readonly Uri _imageSource = new Uri("Images/florida.gif", UriKind.Relative);
        private readonly Uri _imageSource2 = new Uri("Images/hidesinbushes.gif", UriKind.Relative);

        /// <summary>
        /// Gets or sets the path to the source image.
        /// </summary>
        /// <value>The path to the source image.</value>
        public Uri ImageSource
        {
            get { return _imageSource; }
        }

        public Uri ImageSource2
        {
            get { return _imageSource2; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPageViewModel"/> class.
        /// </summary>
        public MainPageViewModel()
        {
            // TODO: gussand
            //Decoders.AddDecoder<PngDecoder>();
            Decoders.AddDecoder<GifDecoder>();
        }
    }
}
