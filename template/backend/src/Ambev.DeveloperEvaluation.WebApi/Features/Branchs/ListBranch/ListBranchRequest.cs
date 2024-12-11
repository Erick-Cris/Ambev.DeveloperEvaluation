namespace Ambev.DeveloperEvaluation.WebApi.Features.Branchs.ListBranch;

/// <summary>
/// Request model for getting a branch list
/// </summary>
public class ListBranchRequest
{
    /// <summary>
    /// The name of the branch to retrieve
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Description of the branch to retrieve
    /// </summary>
    public string Description { get; set; }

}
