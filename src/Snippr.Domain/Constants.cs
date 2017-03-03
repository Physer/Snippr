namespace Snippr.Domain
{
    public static class Constants
    {
        public static class IndexNames
        {
            public const string DefaultSnipperIndex = "snippr";
            public const string DefaultUserIndex = "snippr_users";
        }

        public static class UserProperties
        {
            public const string Anonymous = "Anonymous";
        }

        public static class Exceptions
        {
            public const string NoCodeSupplied = "There is no code supplied for this snippet, please try again";
            public const string NoSnippetFound = "Unable to find a code snippet with the supplied identifier";
            public const string UserExists = "This user already exists and cannot be registered again";
        }
    }
}
