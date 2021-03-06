﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MetaData.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   An MetaData Class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrakeWPF.Services.Encode.Model.Models
{
    public class MetaData
    {
        private string albumArtist;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public MetaData()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public MetaData(MetaData metadata)
        {
            if (metadata != null)
            {
                this.AlbumArtist = metadata.AlbumArtist;
                this.Artist = metadata.Artist;
                this.Comment = metadata.Comment;
                this.Composer = metadata.Composer;
                this.Description = metadata.Description;
                this.Genre = metadata.Genre;
                this.LongDescription = metadata.LongDescription;
                this.Name = metadata.Name;
                this.ReleaseDate = metadata.ReleaseDate;
            }
        }

        /// <summary>
        ///     Gets or sets the album artist.
        /// </summary>
        public string AlbumArtist
        {
            get
            {
                return this.albumArtist;
            }
            set
            {
                this.albumArtist = value;
            }
        }

        /// <summary>
        ///     Gets or sets the artist.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        ///     Gets or sets the comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        ///     Gets or sets the composer.
        /// </summary>
        public string Composer { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the genre.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        ///     Gets or sets the long description.
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the release date.
        /// </summary>
        public string ReleaseDate { get; set; }
    }
}
