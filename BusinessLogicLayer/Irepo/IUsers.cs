using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Irepo
{
    public interface IUsers
    {
        Task AddUsers(Users data);

        Task<bool> Validate(LoginModel data);
    }
}
