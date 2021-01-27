using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoti_Find
{
    enum ReleaseType//forces certain pieces of data to be used
    {
        Single,
        MaxiSingle,
        EP,
        Album
    }

    enum Genre
    {
        Country,
        Rap,
        Rock,
        EDM
    }

    class Release
    {
        public string ReleaseTitle;
        public ReleaseType thisReleaseType;
        public Genre thisGenre;
        public Artist thisArtist;
        public DateTime ReleaseDate;
    }
}
