using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

namespace Docker.Registry.Authentication.Configuration
{
    /// <summary>
    /// Sets up default options for <see cref="AuthenticationTokenOptions"/>.
    /// </summary>
    public class AuthenticationTokenOptionsSetup : IConfigureOptions<AuthenticationTokenOptions>
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationTokenOptionsSetup"/> class.
        /// </summary>
        /// <param name="configuration">A set of key-value application configuration properties.</param>
        public AuthenticationTokenOptionsSetup(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public void Configure(AuthenticationTokenOptions options)
        {
            var section = _configuration.GetSection("authenticationToken");
            if (section.Exists())
            {
                options.Expiration = section.GetValue<uint?>("expiration");
                options.Issuer = section.GetValue<string>("issuer");
            }
        }
    }
}
