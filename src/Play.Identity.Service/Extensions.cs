using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Play.Identity.Service.Entities;
using static Play.Identity.Service.Dtos;

namespace Play.Identity.Service
{
    public static class Extensions
    {

        public static UserDto AsDto(this ApplicationUser user)
        {
            return new UserDto(user.Id, user.UserName, user.Email, user.Gil, user.CreatedOn);
        }

    }
}