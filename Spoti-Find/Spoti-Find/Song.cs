using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoti_Find
{
    class Song
    {
        private string _songTitle;
        private DateTime _releaseDate;
        private Artist Artist;
        private float duration;

        public string SongTitle { get => _songTitle; set => _songTitle = value; }
        public DateTime ReleaseDate { get => _releaseDate; set => _releaseDate = value; }
        public float Duration { get => duration; set => duration = value; }
        internal Artist Artist1 { get => Artist; set => Artist = value; }
    }
}
