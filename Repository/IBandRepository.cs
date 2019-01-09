using FirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Repository
{
    public interface IBandRepository
    {
        /// <summary>
        /// get all bands
        /// </summary>
        /// <returns>A list of bands</returns>
        List<Band> GetBands();
        /// <summary>
        /// get a band
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A band</returns>
        Band GetBand(int id);
    }
}
