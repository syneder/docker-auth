using System.Net;

namespace Docker.Registry.Authentication.DataLayer.Models
{
    /// <summary>
    /// Represents the locks of the specified account in the authentication system.
    /// </summary>
    public class AccountLockEntity
    {
        /// <summary>
        /// Get or set the account name for this lock.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the IP address affected by this lock.
        /// </summary>
        public IPAddress Address { get; set; }

        /// <summary>
        /// Gets or sets the number of failed authentication attempts on this lock.
        /// </summary>
        public ushort Count { get; set; }
    }
}
