using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rainbow_unicorn;

public class User
{

    public User()
    {
        
    }
    
    public User(string userId, string customerName, DateTime createdDate)
    {
        UserId = userId;
        CustomerName = customerName;
        CreatedDate = createdDate;
    }
    

    public string UserId { get; set; }
    public string CustomerName { get; set; }
    public DateTime CreatedDate { get; set; }
    
    public ICollection<UserPurchase>? UserPurchases { get; set; }
    public virtual Customer? Customer { get; set; }
}