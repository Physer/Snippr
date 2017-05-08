namespace Snippr.Domain
{
    public static class Constants
    {
        /// <summary>
        /// Names of elastic indices that are used throughout Snippr
        /// </summary>
        public static class IndexNames
        {
            public const string DefaultSnipperIndex = "snippr";
            public const string DefaultUserIndex = "snippr_users";
        }

        /// <summary>
        /// Custom user properties, for example default settings
        /// </summary>
        public static class UserProperties
        {
            public const string Anonymous = "Anonymous";
        }

        /// <summary>
        /// Common exceptions, used throughout the application
        /// </summary>
        public static class Exceptions
        {
            public const string NoCodeSupplied = "There is no code supplied for this snippet, please try again";
            public const string NoSnippetFound = "Unable to find a code snippet with the supplied identifier";
            public const string UserExists = "This user already exists and cannot be registered again";
            public const string UserDoesNotExist = "This user does not exist";
            public const string InvalidCredentials = "Invalid credentials";
        }
    }
}
