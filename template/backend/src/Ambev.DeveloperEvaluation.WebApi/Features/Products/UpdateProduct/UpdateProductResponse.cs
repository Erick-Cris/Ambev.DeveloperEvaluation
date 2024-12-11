namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct;

/// <summary>
/// API response model for UpdateProduct operation
/// </summary>
public class UpdateProductResponse
{
    /// <summary>
    /// The unique identifier of the update product
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The product's name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The product's description
    /// </summary>
    public string Description { get; set; } = string.Empty;


    /// <summary>
    /// The product's price
    /// </summary>
    public decimal Price { get; set; } = decimal.Zero;
}
