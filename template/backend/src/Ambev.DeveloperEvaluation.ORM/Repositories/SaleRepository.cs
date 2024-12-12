using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ISaleRepository using Entity Framework Core
/// </summary>
public class SaleRepository : ISaleRepository
{
    private readonly SalesContext _context;

    /// <summary>
    /// Initializes a new instance of SaleRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public SaleRepository(SalesContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new sale in the database
    /// </summary>
    /// <param name="sale">The sale to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sale</returns>
    public async Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default)
    {
        await _context.Sales.AddAsync(sale, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return sale;
    }

    /// <summary>
    /// Retrieves a sale by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the sale</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The sale if found, null otherwise</returns>
    public async Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Sales.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    /// Retrieves a list of sales based on the provided filters
    /// </summary>
    /// <param name="customerExternalId">The customer's id of the sale to retrieve</param>
    /// <param name="customerName">The customer's name of the sale to retrieve</param>
    /// <param name="customerDocument">The customer's document of the sale to retrieve</param>
    /// <param name="branchExternalId">The branch's id of the sale to retrieve</param>
    /// <param name="branchName">The branch's name of the sale to retrieve</param>
    /// <param name="status">The status of the sale to retrieve</param>
    /// <param name="totalAmount">The total amount of the sale to retrieve</param>
    /// <param name="createdAt">The creation date and time of the sale to retrieve</param>
    /// <returns>A list of sales that match the filters</returns>
    public async Task<List<Sale>> ListAsync(
        Guid? customerExternalId, 
        string customerName, 
        string customerDocument,
        Guid? branchExternalId,
        string branchName,
        SaleStatus? status,
        decimal? totalAmount,
        DateTime? createdAt,
        CancellationToken cancellationToken = default
        )
    {
        var query = _context.Sales.AsQueryable();

        if (customerExternalId.HasValue)
        {
            query = query.Where(p => p.CustomerExternalId == customerExternalId);
        }

        if (!string.IsNullOrEmpty(customerName))
        {
            query = query.Where(p => p.CustomerName.ToLower().Trim().Contains(customerName.ToLower().Trim()));
        }

        if (!string.IsNullOrEmpty(customerDocument))
        {
            query = query.Where(p => p.CustomerDocument.ToLower().Trim().Contains(customerDocument.ToLower().Trim()));
        }

        if (branchExternalId.HasValue)
        {
            query = query.Where(p => p.BranchExternalId == branchExternalId);
        }

        if (!string.IsNullOrEmpty(branchName))
        {
            query = query.Where(p => p.BranchName.ToLower().Trim().Contains(branchName.ToLower().Trim()));
        }

        if (status.HasValue)
        {
            query = query.Where(p => p.Status == status);
        }

        if (totalAmount.HasValue)
        {
            query = query.Where(p => p.TotalAmount == totalAmount.Value);
        }

        if (createdAt.HasValue)
        {
            query = query.Where(p => p.CreatedAt.Date == createdAt.Value.Date);
        }

        return await query.ToListAsync(cancellationToken);
    }

    /// <summary>
    /// Updates an existing sale in the database
    /// </summary>
    /// <param name="sale">The sale to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The updated sale</returns>
    public async Task<Sale> UpdateAsync(Sale sale, CancellationToken cancellationToken = default)
    {
        _context.Sales.Update(sale);
        await _context.SaveChangesAsync(cancellationToken);
        return sale;
    }


    /// <summary>
    /// Deletes a sale from the database
    /// </summary>
    /// <param name="id">The unique identifier of the sale to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the sale was deleted, false if not found</returns>
    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var sale = await GetByIdAsync(id, cancellationToken);
        if (sale == null)
            return false;

        _context.Sales.Remove(sale);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
