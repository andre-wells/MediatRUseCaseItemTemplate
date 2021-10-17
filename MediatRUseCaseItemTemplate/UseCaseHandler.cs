using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;

namespace $rootnamespace$
{
    public class $basename$Handler : IRequestHandler<$basename$Request, $basename$Response>
    {
        private readonly ILogger<$basename$Handler> _logger;

        public $basename$Handler(ILogger<$basename$Handler> logger)
        {
            _logger = logger;
        }

        public Task<$basename$Response> Handle($basename$Request request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
