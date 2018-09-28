using CoreAbstractions.Entities;
using System;
using System.Threading.Tasks;

namespace ServerAbstractions.Services
{
    public interface IUserService
    {
        Task<User> GetAsync(Guid userId);
    }
}
