﻿using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        //Task<List<Villa>> GetAllAsync(Expression<Func<Villa, bool>> filter = null);
        //Task<Villa> GetAsync(Expression<Func<Villa, bool>> filter = null, bool tracked = true);
        //Task CreateAsync(Villa entity);
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
        //Task RemoveAsync(Villa entity);
        //Task SaveAsync();
    }
}
