using Ambev.DeveloperEvaluation.Domain.Entities;


namespace Ambev.DeveloperEvaluation.Domain.Events
{
    public class BranchRegisteredEvent
    {
        public Branch Branch { get; }

        public BranchRegisteredEvent(Branch branch)
        {
            Branch = branch;
        }
    }
}
