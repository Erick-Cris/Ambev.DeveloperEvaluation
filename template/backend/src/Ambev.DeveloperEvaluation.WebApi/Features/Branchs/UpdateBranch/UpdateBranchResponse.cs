namespace Ambev.DeveloperEvaluation.WebApi.Features.Branchs.UpdateBranch;

/// <summary>
/// API response model for UpdateBranch operation
/// </summary>
public class UpdateBranchResponse
{
    /// <summary>
    /// The unique identifier of the update branch
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The branch's name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The branch's description
    /// </summary>
    public string Description { get; set; } = string.Empty;

}
