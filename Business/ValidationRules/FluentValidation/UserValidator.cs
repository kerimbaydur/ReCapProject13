﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(us => us.FirstName).NotEmpty();
            RuleFor(us => us.Email).NotEmpty();
            RuleFor(us => us.LastName).NotEmpty();
            RuleFor(us => us.Password).NotEmpty();
        }
    }
}
