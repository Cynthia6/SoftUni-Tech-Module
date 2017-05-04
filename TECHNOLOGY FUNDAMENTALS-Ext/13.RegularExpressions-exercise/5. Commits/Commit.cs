using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Commits
{
    public class Commit
    {
        public string Hash { get; set; }

        public string Message { get; set; }

        public int Additions { get; set; }

        public int Deletions { get; set; }
    }
}