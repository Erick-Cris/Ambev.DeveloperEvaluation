using Ambev.DeveloperEvaluation.Domain.Entities;


namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for SaleProduct entity operations
    /// </summary>
    public interface ISaleProductRepository
    {
        /// <summary>
        /// Creates a new saleProduct in the repository
        /// </summary>
        /// <param name="saleProduct">The saleProduct to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created saleProduct</returns>
        Task<SaleProduct> CreateAsync(SaleProduct saleProduct, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a saleProduct by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the saleProduct</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The saleProduct if found, null otherwise</returns>
        Task<SaleProduct?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of saleProducts based on the provided filters
        /// </summary>
        /// <param name="productExternalId">The external id of the product</param>
        /// <param name="productName">The name of the product</param>
        /// <param name="productDescription">The description of the product</param>
        /// <param name="productPrice">The price of the product</param>
        /// <param name="discount">The discount of the product</param>
        /// <param name="quantity">The quantity of the product</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A list of saleProducts that match the filters</returns>
        Task<List<SaleProduct>> ListAsync(
            Guid? saleId, 
            Guid? productExternalId, 
            string productName, 
            string productDescription, 
            decimal? productPrice, 
            decimal? discount, 
            uint? quantity,
            CancellationToken cancellationToken = default
            );

        /// <summary>
        /// Updates an existing saleProduct in the repository
        /// </summary>
        /// <param name="saleProduct">The saleProduct to update</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated saleProduct</returns>
        Task<SaleProduct> UpdateAsync(SaleProduct saleProduct, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a saleProduct from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the saleProduct to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the saleProduct was deleted, false if not found</returns>
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
