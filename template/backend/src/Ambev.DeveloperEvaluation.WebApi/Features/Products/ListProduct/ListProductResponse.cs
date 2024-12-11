namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProduct;

/// <summary>
/// API response model for ListProduct operation
/// </summary>
public class ListProductResponse
{
    /// <summary>
    /// The unique identifier of the product
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
    /// The products's price address
    /// </summary>
    public decimal Price { get; set; } = decimal.Zero;
}
