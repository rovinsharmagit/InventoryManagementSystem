namespace Application.DTO.Request.Identity
{
    public static class Policy
    {
        public const string AdminPolicy = "AdminPolicy";
        public const string ManagerPolicy = "ManagerPolicy";
        public const string UserPolicy = "UserPolicy";

        public static class RoleClaim
        {
            public const string Admin = "Admin";
            public const string Manager = "Manager";
            public const string User = "User";
        }
    }
}
