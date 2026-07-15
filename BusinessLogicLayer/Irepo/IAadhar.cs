using BusinessLogicLayer.Migrations;
using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Irepo
{
    public interface IAadhar
    {
        Task<IList<Aadhar>> GetAadhar();

        Task<IList<Pan>> GetPan();
        Task<IList<Country>> GetCountry();
    }
}
