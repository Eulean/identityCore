using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace identityCore.Model
{
    public class User : IdentityUser
    {
        public string? Initial { get; set;}
    }
}