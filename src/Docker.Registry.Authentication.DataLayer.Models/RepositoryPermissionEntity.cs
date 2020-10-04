namespace Docker.Registry.Authentication.DataLayer.Models
{
    /// <summary>
    /// Represents the permissions for the specified account and repository in the authentication system.
    /// </summary>
    public class RepositoryPermissionEntity
    {
        /// <summary>
        /// Gets or sets the account name for this permission entry.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the repository name for this permission entry.
        /// </summary>
        public string RepositoryName { get; set; }

        /// <summary>
        /// Gets or sets the access level for the specified account to the specified repository.
        /// </summary>
        public ushort Level { get; set; }
    }
}
