using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Animes
{
    public interface IComparableAnime : IComparable
    {
        int CompareTo(object? obj, int option);

        //class CompareByName : IComparer<Anime>
        //{
        //    public int Compare(Anime x, Anime y)
        //    {
        //        if (x.name == null || y.name == null)
        //        {
        //            return 0;
        //        }

        //        return x.name.CompareTo(y.name);

        //    }
        //}


        //animeList.Sort(new CompareByName());
    }
}
