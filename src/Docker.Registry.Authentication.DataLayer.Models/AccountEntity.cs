namespace Docker.Registry.Authentication.DataLayer.Models
{
    /// <summary>
    /// Represents an account in the authentication system.
    /// </summary>
    public class AccountEntity
    {
        /// <summary>
        /// Gets or sets the name for this account.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a salted and hashed representation of the password for this account.
        /// </summary>
        public string PasswordHash { get; set; }
    }
}
