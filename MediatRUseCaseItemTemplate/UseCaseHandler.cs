using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;

namespace $rootnamespace$
{
    public class $safeitemrootname$Handler : IRequestHandler<$safeitemrootname$Request, $safeitemrootname$Response>
    {
        private readonly ILogger<$safeitemrootname$Handler> _logger;

        public $safeitemrootname$Handler(ILogger<$safeitemrootname$Handler> logger)
        {
            _logger = logger;
        }

        public Task<$safeitemrootname$Response> Handle($safeitemrootname$Request request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
