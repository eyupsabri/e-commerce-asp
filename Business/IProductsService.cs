﻿using Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IProductsService
    {
        Task<List<ProductResponse>> GetAllProductsByCategoryId(int categoryId);
        Task<List<SessionOrder>> GetOrderItems(List<string> ProductsId, List<int> Quantities);
    }
}
