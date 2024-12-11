﻿using Ambev.DeveloperEvaluation.Domain.Entities;


namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    /// <summary>
    /// Repository interface for Branch entity operations
    /// </summary>
    public interface IBranchRepository
    {
        /// <summary>
        /// Creates a new branch in the repository
        /// </summary>
        /// <param name="branch">The branch to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created branch</returns>
        Task<Branch> CreateAsync(Branch branch, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a branch by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the branch</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The branch if found, null otherwise</returns>
        Task<Branch?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of branchs based on the provided filters
        /// </summary>
        /// <param name="name">The name of the branch</param>
        /// <param name="description">The description of the branch</param>
        /// <param name="price">The price of the branch</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A list of branchs that match the filters</returns>
        Task<List<Branch>> ListAsync(string name, string description, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing branch in the repository
        /// </summary>
        /// <param name="branch">The branch to update</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The updated branch</returns>
        Task<Branch> UpdateAsync(Branch branch, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a branch from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the branch to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the branch was deleted, false if not found</returns>
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    }
}