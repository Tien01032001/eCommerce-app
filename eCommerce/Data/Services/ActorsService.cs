using eCommerce.Data.Base;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace eCommerce.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
