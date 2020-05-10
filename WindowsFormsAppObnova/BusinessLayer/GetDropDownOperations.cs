using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public class GetMediaTypeOperation : Operation {
        
        public override OperationResult Execute()
        {
            var query = Context.MediaType.AsQueryable();

            var fistObj = new MediaTypeDto { Id = 0, Name = "" };

            var data = query.Select(x => new MediaTypeDto
            {
                Id = x.MediaTypeId,
                Name = x.Name
            }).ToList();

            var firstItem = new MediaTypeDto { Id = 0, Name = "" };

            data.Insert(0, firstItem);

            return new OperationResult
            {
                Data = data
            };

        }

    }

    public class GetAlbumOperation : Operation
    {

        public override OperationResult Execute()
        {
            var query = Context.Album.AsQueryable();

            var fistObj = new AlbumDto { Id = 0, Name = "" };

            var data = query.Select(x => new AlbumDto
            {
                Id = x.AlbumId,
                Name = x.Title
            }).ToList();

            var firstItem = new AlbumDto { Id = 0, Name = "" };

            data.Insert(0, firstItem);

            return new OperationResult
            {
                Data = data
            };

        }

    }

    public class GetGenreOperation : Operation
    {

        public override OperationResult Execute()
        {
            var query = Context.Genre.AsQueryable();

            var fistObj = new GenreDto { Id = 0, Name = "" };

            var data = query.Select(x => new GenreDto
            {
                Id = x.GenreId,
                Name = x.Name
            }).ToList();

            var firstItem = new GenreDto { Id = 0, Name = "" };

            data.Insert(0, firstItem);

            return new OperationResult
            {
                Data = data
            };

        }

    }

    public class GetPlaylistOperation : Operation
    {

        public override OperationResult Execute()
        {
            var query = Context.Playlist.AsQueryable();

            var fistObj = new PlaylistDto { Id = 0, Name = "" };

            var data = query.Select(x => new PlaylistDto
            {
                Id = x.PlaylistId,
                Name = x.Name
            }).ToList();

            return new OperationResult
            {
                Data = data
            };

        }

    }
}
