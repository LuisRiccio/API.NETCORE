using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Security
{
    public class TokenConfiguration
    {
        public string Audiance { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
