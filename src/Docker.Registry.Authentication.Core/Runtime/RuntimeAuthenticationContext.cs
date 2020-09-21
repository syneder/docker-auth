using Docker.Registry.Authentication.Configuration.Runtime.Models;
using System.Collections.Generic;

namespace Docker.Registry.Authentication.Configuration.Runtime
{
    /// <summary>
    /// Encapsulates all Docker Registry authentication specific information about an individual request.
    /// </summary>
    public class RuntimeAuthenticationContext
    {
        /// <summary>
        /// Gets or sets specific information about an authenticated account.
        /// </summary>
        public Account AuthenticatedAccount { get; set; }

        /// <summary>
        /// Gets the <see cref="AuthenticationTokenOptions"/> for the authentication system.
        /// </summary>
        public AuthenticationTokenOptions Options { get; internal set; }

        /// <summary>
        /// Gets or sets an enumeration of permissions for an authenticated user or individual request.
        /// </summary>
        public IEnumerable<RepositoryPermission> Permissions { get; set; }
    }
}
