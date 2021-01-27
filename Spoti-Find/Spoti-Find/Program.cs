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
            Release aq = new Release();
            aq.ReleaseDate = new DateTime(2020, 9, 29);
            aq.ReleaseTitle = "Folklore";






        }
    }
}
