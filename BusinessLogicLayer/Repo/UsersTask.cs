using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repo
{
    public class UsersTask : IUsers
    {
        public AppDb _db;
        public UsersTask(AppDb db)
        {
            _db = db;
        }

        public async Task AddUsers(Users data)
        {
            await _db.Users.AddAsync(data);
            await _db.SaveChangesAsync();
        }

        public async Task<bool> Validate(LoginModel data)
        {
            return await _db.Users.AnyAsync(x => x.Email == data.Email && x.Password == data.Password);
        }
    }
}
