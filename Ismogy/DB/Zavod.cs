using System;
using System.Collections.Generic;

namespace Ismogy.DB
{
    public partial class Zavod
    {
        public int Id { get; set; }
        public  string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Rank { get; set; }
        public string? House { get; set; }
    }
}
