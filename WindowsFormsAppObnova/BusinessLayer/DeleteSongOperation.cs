using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public class DeleteSongOperation : Operation
    {
        private int id;
        
        public DeleteSongOperation(int id) {
            var track = Context.Track.Find(id);
            if (track == null)
            {
                throw new Exception("Track does not exist");
            }

            this.id = id;
        }

        public override OperationResult Execute()
        {
            if (Context.InvoiceLine.Any(x => x.TrackId == id)){
                throw new InvalidOperationException("Song is inside Invoice lines table.");
            }

            var track = Context.Track.Find(id);

            foreach(var playlist in track.Playlist)
            {
                playlist.Track.Remove(track);
            }

            Context.Track.Remove(track);

            Context.SaveChanges();

            return new OperationResult();
        }
    }
}
