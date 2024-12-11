namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProduct;

/// <summary>
/// Request model for getting a product list
/// </summary>
public class ListProductRequest
{
    /// <summary>
    /// The name of the product to retrieve
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Description of the product to retrieve
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The price of the product to retrieve
    /// </summary>
    public decimal? Price { get; set; }
}
