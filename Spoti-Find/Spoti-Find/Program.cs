using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoti_Find
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taylor Swift
            Artist TaylorSwift = new Artist();
            TaylorSwift.Name = "Taylor Swift";

            Song s1 = new Song();
            s1.Artist1 = TaylorSwift;
            s1.Duration = 71f;
            s1.SongTitle = "Welcome to New York";

            Song s2 = new Song();
            s2.Artist1 = TaylorSwift;
            s2.Duration = 200f;
            s2.SongTitle = "Gorgeous";

            Song s3 = new Song();
            s3.Artist1 = TaylorSwift;
            s3.Duration = 320f;
            s3.SongTitle = "Willow";
            
            Release ts = new Release();
            ts.ReleaseDate = new DateTime(2020, 9, 29);
            ts.ReleaseTitle = "Folklore";
            ts.thisArtist = TaylorSwift;
            ts.thisGenre = Genre.Pop;
            ts.thisReleaseType = ReleaseType.Album;
            ts.SongsInRelease.Add(s1);
            ts.SongsInRelease.Add(s2);
            ts.SongsInRelease.Add(s3);

            //Hozier

            Artist Hozier = new Artist();
            Hozier.Name = "Hozier";

            Song sp1 = new Song();
            sp1.Artist1 = Hozier;
            sp1.Duration = 230f;
            sp1.SongTitle = "Work Song";

            Song sp2 = new Song();
            sp2.Artist1 = Hozier;
            sp2.Duration = 350f;
            sp2.SongTitle = "From Eden";

            Song sp3 = new Song();
            sp3.Artist1 = Hozier;
            sp3.Duration = 320f;
            sp3.SongTitle = "Shrike";

            Release hz = new Release();
            hz.ReleaseDate = new DateTime(2020, 9, 29);
            hz.ReleaseTitle = "Take Me to Church";
            hz.thisArtist = Hozier;
            hz.thisGenre = Genre.Pop;
            hz.thisReleaseType = ReleaseType.Album;
            hz.SongsInRelease.Add(sp1);
            hz.SongsInRelease.Add(sp2);
            hz.SongsInRelease.Add(sp3);

            Playlist myPlaylist = new Playlist();
            myPlaylist.ReleaseList.Add(ts);
            myPlaylist.ReleaseList.Add(hz);
            Console.ReadLine();









        }
    }
}
