using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Migrations;
using BusinessLogicLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repo
{
    public class AadharBl : IAadhar
    {

        public AppDb _db;
        public AadharBl(AppDb db)
        {
            _db = db;
        }

        public async Task<IList<Aadhar>> GetAadhar()
        {
            return await _db.aadhar.Include("_pan").ToListAsync();
        }
        public async Task<IList<Pan>> GetPan()
        {
            return await _db.pan.Include("_Aadhar").ToListAsync();
        }
        public async Task<IList<Country>> GetCountry()
        {
            return await _db.Country.Include("_state").ToListAsync();
        }

    }
}
