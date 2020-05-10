using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppObnova.BusinessLayer
{
    public class Dto
    {
    }

    public class SongDto : Dto { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public string GenreName { get; set; }
        public IEnumerable<string> PlaylistName { get; set; } = new List<string>();
        public int PlaylistCount => PlaylistName.Count();
        public string Media { get; set; }
        public decimal Price { get; set; }
        public int TotalSoldItems { get; set; }
    }

    public class MediaTypeDto : Dto { 
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class AlbumDto : Dto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class GenreDto : Dto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PlaylistDto : Dto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class CreateSongDto : Dto
    {
        public int SongId { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public string Composer { get; set; }
        public int Bytes { get; set; }
        public int Miliseconds { get; set; }
        public List<int> PlaylistIDs { get; set; } = new List<int>();
        public int MediaId { get; set; }
        public decimal Price { get; set; }
    }
}
