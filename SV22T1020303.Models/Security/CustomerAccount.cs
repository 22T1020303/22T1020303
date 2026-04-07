namespace LiteCommerce.Models.Security
{
    public class CustomerAccount
    {
        public int CustomerID { get; set; }
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public bool IsActive { get; set; }
    }
}