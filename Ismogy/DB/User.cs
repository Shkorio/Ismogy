﻿using System;
using System.Collections.Generic;

namespace Ismogy.DB
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
    }
}
