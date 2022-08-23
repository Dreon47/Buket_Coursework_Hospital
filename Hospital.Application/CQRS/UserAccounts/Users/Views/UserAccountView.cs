﻿using System;

namespace Hospital.Application.CQRS.UserAccounts.Views
{
    public class UserAccountView
    {
        public Guid Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}