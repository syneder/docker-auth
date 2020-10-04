using System;
using System.Net;

namespace Docker.Registry.Authentication.DataLayer.Models
{
    /// <summary>
    /// Represents the issued refresh tokens for the specified account in the authentication system.
    /// </summary>
    public class TokenEntity
    {
        /// <summary>
        /// Gets or sets a unique identifier for this token.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the account name associated with this token.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the IP address from which this token is allowed to be used.
        /// </summary>
        public IPAddress IPAddress { get; set; }
    }
}
