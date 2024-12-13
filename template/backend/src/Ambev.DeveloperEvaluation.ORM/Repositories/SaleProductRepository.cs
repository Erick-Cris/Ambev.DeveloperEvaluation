using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ISaleProductRepository using Entity Framework Core
/// </summary>
public class SaleProductRepository : ISaleProductRepository
{
    private readonly SalesContext _context;

    /// <summary>
    /// Initializes a new instance of SaleProductRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public SaleProductRepository(SalesContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new saleProduct in the database
    /// </summary>
    /// <param name="saleProduct">The saleProduct to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created saleProduct</returns>
    public async Task<SaleProduct> CreateAsync(SaleProduct saleProduct, CancellationToken cancellationToken = default)
    {
        await _context.SaleProducts.AddAsync(saleProduct, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return saleProduct;
    }

    /// <summary>
    /// Retrieves a saleProduct by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the saleProduct</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The saleProduct if found, null otherwise</returns>
    public async Task<SaleProduct?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.SaleProducts.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    /// Retrieves a list of saleProducts based on the provided filters
    /// </summary>
    /// <param name="name">The name of the saleProduct</param>
    /// <param name="description">The description of the saleProduct</param>
    /// <param name="price">The price of the saleProduct</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of saleProducts that match the filters</returns>
    public async Task<List<SaleProduct>> ListAsync(
        Guid? saleId, 
        Guid? productExternalId, 
        string productName, 
        string productDescription, 
        decimal?  productPrice, 
        decimal? discount,  
        uint? quantity, 
        CancellationToken cancellationToken = default)
    {
        var query = _context.SaleProducts.AsQueryable();

        if(saleId.HasValue)
        {
            query = query.Where(p => p.SaleId == saleId);
        }

        if (productExternalId.HasValue)
        {
            query = query.Where(p => p.ProductExternalId == productExternalId);
        }

        if (!string.IsNullOrEmpty(productName))
        {
            query = query.Where(p => p.ProductName.ToLower().Trim().Contains(productName.ToLower().Trim()));
        }

        if (!string.IsNullOrEmpty(productDescription))
        {
            query = query.Where(p => p.ProductDescription.ToLower().Trim().Contains(productDescription.ToLower().Trim()));
        }

        if (productPrice.HasValue)
        {
            query = query.Where(p => p.ProductPrice == productPrice.Value);
        }

        if (discount.HasValue)
        {
            query = query.Where(p => p.Discount == discount.Value);
        }

        if (quantity.HasValue)
        {
            query = query.Where(p => p.Quantity == quantity.Value);
        }

        return await query.ToListAsync(cancellationToken);
    }

    /// <summary>
    /// Updates an existing saleProduct in the database
    /// </summary>
    /// <param name="saleProduct">The saleProduct to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated saleProduct</returns>
    public async Task<SaleProduct> UpdateAsync(SaleProduct saleProduct, CancellationToken cancellationToken = default)
    {
        _context.SaleProducts.Update(saleProduct);
        await _context.SaveChangesAsync(cancellationToken);
        return saleProduct;
    }


    /// <summary>
    /// Deletes a saleProduct from the database
    /// </summary>
    /// <param name="id">The unique identifier of the saleProduct to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the saleProduct was deleted, false if not found</returns>
    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var saleProduct = await GetByIdAsync(id, cancellationToken);
        if (saleProduct == null)
            return false;

        _context.SaleProducts.Remove(saleProduct);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
