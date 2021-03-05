﻿using CarSeller.Entities.Models;
using System.Threading.Tasks;

namespace CarSeller.DataAccess.Interfaces
{
    public interface ISellerRepository
    {
        Task CreateSeller(Seller entity);
    }
}
