using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public class GetSongOperation : Operation
    {
        public override OperationResult Execute()
        {
            var query = Context.Track.AsQueryable();

            query.Where(t => t.InvoiceLine.Any());

            var songs = query.Select(s => new SongDto
            {
                Id = s.TrackId,
                Name = s.Name,
                ArtistName = s.Album.Artist.Name,
                AlbumName = s.Album.Title,
                Media = s.MediaType.Name,
                Price = s.UnitPrice,
                PlaylistName = s.Playlist.Select(p => p.Name),
                TotalSoldItems = s.InvoiceLine.Count(),
                GenreName = s.Genre.Name
            }).OrderByDescending(x => x.Id).Take(100).ToList();

            return new OperationResult
            {
                Data = songs
            };

        }
    }
}
