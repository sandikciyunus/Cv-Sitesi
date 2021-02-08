﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cv.WebUI.Models
{
    public class AppUserListViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string ShortDescription { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string GithubLink { get; set; }
        public string LınkedinLink { get; set; }
        public string PhoneNumber { get; set; }
    }
}