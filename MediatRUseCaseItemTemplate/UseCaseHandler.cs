using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRUseCaseItemTemplate
{
    public class UseCaseHandler : IRequestHandler<UseCaseRequest, UseCaseResponse>
    {
        private readonly ILogger<UseCaseHandler> _logger;

        public UseCaseHandler(ILogger<UseCaseHandler> logger)
        {
            _logger = logger;
        }

        public Task<UseCaseResponse> Handle(UseCaseRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
