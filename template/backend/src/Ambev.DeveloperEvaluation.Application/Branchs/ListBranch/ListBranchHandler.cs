using Ambev.DeveloperEvaluation.Application.Branchs.ListBranch;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.ListBranch
{
    /// <summary>
    /// Handler for processing ListBranchCommand requests
    /// </summary>
    public class ListBranchHandler : IRequestHandler<ListBranchCommand, List<ListBranchResult>>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of ListBranchHandler
        /// </summary>
        /// <param name="branchRepository">The branch repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for ListBranchCommand</param>
        public ListBranchHandler(
            IBranchRepository branchRepository,
            IMapper mapper)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the ListBranchCommand request
        /// </summary>
        /// <param name="request">The ListBranch command</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The branch details if found</returns>
        public async Task<List<ListBranchResult>> Handle(ListBranchCommand request, CancellationToken cancellationToken)
        {
            var validator = new ListBranchValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var branchs = await _branchRepository.ListAsync(request.Name, request.Description, cancellationToken);
            //if (branch == null)
            //    throw new KeyNotFoundException($"Branch with ID {request.Id} not found");

            return _mapper.Map<List<ListBranchResult>>(branchs);
        }
    }
}
