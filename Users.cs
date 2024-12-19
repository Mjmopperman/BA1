using System;
using System.Text;
using System.Security.Cryptography;

namespace BlazorApp{


public class Users{
    public  Dictionary<string,string> UsernamePassword =[];
    public Users(){
        UsernamePassword.Add("marinus.opperman@gmail.com",QuickHash("Xiko304050#$%"));
    }

    public  string QuickHash(string input)
    {
        var inputBytes = Encoding.UTF8.GetBytes(input);
        var inputHash = SHA256.HashData(inputBytes);
        return Convert.ToHexString(inputHash);
    }
    
    }
}