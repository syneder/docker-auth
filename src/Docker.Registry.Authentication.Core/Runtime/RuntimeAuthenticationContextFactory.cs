using Microsoft.Extensions.Options;
using System;

namespace Docker.Registry.Authentication.Configuration.Runtime
{
    /// <summary>
    /// A factory that can create <see cref="RuntimeAuthenticationContext"/> instances.
    /// </summary>
    public class RuntimeAuthenticationContextFactory
    {
        private readonly AuthenticationTokenOptions _options;

        /// <summary>
        /// Creates a new <see cref="RuntimeAuthenticationContext"/>.
        /// </summary>
        /// <param name="options">The <see cref="AuthenticationTokenOptions"/>.</param>
        public RuntimeAuthenticationContextFactory(IOptions<AuthenticationTokenOptions> options)
        {
            _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Creates an <see cref="RuntimeAuthenticationContext"/>.
        /// </summary>
        /// <returns>The <see cref="RuntimeAuthenticationContext"/>.</returns>
        public RuntimeAuthenticationContext Create() => new RuntimeAuthenticationContext
        {
            Options = _options
        };
    }
}
