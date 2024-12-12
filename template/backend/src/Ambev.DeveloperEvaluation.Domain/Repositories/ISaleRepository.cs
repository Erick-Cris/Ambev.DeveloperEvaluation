using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;


namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for Sale entity operations
    /// </summary>
    public interface ISaleRepository
    {
        /// <summary>
        /// Creates a new sale in the repository
        /// </summary>
        /// <param name="sale">The sale to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created sale</returns>
        Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a sale by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the sale</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The sale if found, null otherwise</returns>
        Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of sales based on the provided filters
        /// </summary>
        /// <param name="name">The name of the sale</param>
        /// <param name="externalCustomerId">The external customer Id of the sale</param>
        /// <param name="customerName">The external customer's name of the sale</param>
        /// <param name="customerDocument">The external of the sale</param>
        /// <param name="externalBranchId">The external branch Id of the sale</param>
        /// <param name="branchName">The branch's name of the sale</param>
        /// <param name="status">The Status of the sale</param>
        /// <param name="totalAmount">The total amount of the sale</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A list of sales that match the filters</returns>
        Task<List<Sale>> ListAsync(Guid? externalCustomerId, string customerName, string customerDocument, Guid? externalBranchId, string branchName, SaleStatus? status, decimal? totalAmount, DateTime? createdAt, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing sale in the repository
        /// </summary>
        /// <param name="sale">The sale to update</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated sale</returns>
        Task<Sale> UpdateAsync(Sale sale, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a sale from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the sale to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the sale was deleted, false if not found</returns>
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
