﻿using Application.Messages.Catalog.Response;
using System.Threading.Tasks;

namespace Application.ServiceClients.Interfaces
{
    public interface ICatalogServiceClient
    {
        Task<ProductResponseMessage> GetProductByIdAsync(long id);
    }
}
