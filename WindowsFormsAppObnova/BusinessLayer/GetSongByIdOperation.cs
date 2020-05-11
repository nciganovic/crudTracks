using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public class GetSongByIdOperation : Operation
    {
        private int id;

        public GetSongByIdOperation(int id) {
            this.id = id;
        }

        public override OperationResult Execute()
        {
            var query = Context.Track.AsQueryable();

            query = query.Where(x => x.TrackId == id);

            var item = query.Select(x => new EditSongDto
            {
                SongId = id,
                AlbumId = x.AlbumId ?? 0,
                Bytes = x.Bytes ?? 0,
                Composer = x.Composer ?? "",
                GenreId = x.GenreId ?? 0,
                MediaId = x.MediaTypeId,
                Miliseconds = x.Milliseconds,
                Name = x.Name,
                Price = x.UnitPrice
            });

            return new OperationResult
            {
                Data = item
            };
        }
    }
}
