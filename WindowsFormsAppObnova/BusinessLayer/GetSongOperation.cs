using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public class GetSongOperation : Operation
    {
        private string keyword;

        public GetSongOperation()
        {
            
        }

        public GetSongOperation(string keyword = null) {
            this.keyword = keyword;
        }

        public override OperationResult Execute()
        {
            var query = Context.Track.AsQueryable();

            query.Where(t => t.InvoiceLine.Any());

            if (!String.IsNullOrEmpty(keyword)) {
                query = query.Where(
                        x => x.Name.Contains(keyword)
                    );
            }

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
