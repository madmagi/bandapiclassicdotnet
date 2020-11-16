using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiclassnet.Models
{
    interface IBandRepository
    {
        IEnumerable<Band> GetAllBands();
        Band AddBand(Band band);
        Band GetBand(string name);
        bool DeleteBand(string name);


        Band UpdateRating(string name, int rating);

        Band UpdateBand(Band band);

        IEnumerable<Band> GetBandByQuery(int rating, int year);

    }
}
