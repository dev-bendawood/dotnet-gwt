using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;

namespace JwtExample.Models
{
    public class Login
    {
        public string username { get; set; }
        public string password { get; set; }

        public Login(){}

        public Login(string username, string password){
            this.username=username;
            this.password=password;
        }

        public static string GetClaim(IEnumerable<Claim> claims, string type){
            return claims.Where(c => c.Type == type)
                   .Select(c => c.Value).SingleOrDefault();
        }
    }
}