﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppObnova.DataLayer;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public class CreateSongOperation : Operation
    {
        private CreateSongDto dto;

        public CreateSongOperation(CreateSongDto dto) {
            this.dto = dto;
        }

        public override OperationResult Execute()
        {
            dto.SongId = Context.Track.OrderByDescending(x => x.TrackId).First().TrackId + 1;

            var track = new Track { 
                TrackId = dto.SongId,
                Name = dto.Name,
                AlbumId = dto.AlbumId,
                Bytes = dto.Bytes,
                Composer = dto.Composer,
                GenreId = dto.GenreId,
                MediaTypeId = dto.MediaId,
                Milliseconds = dto.Miliseconds,
                UnitPrice = dto.Price,
            };

            Context.Track.Add(track);

            track.Playlist = new List<Playlist>();

            foreach (var id in dto.PlaylistIDs) {
                var playlist = Context.Playlist.Find(id);
                track.Playlist.Add(playlist);
            }

            Context.SaveChanges();

            return new OperationResult();
            
        }
    }
}
