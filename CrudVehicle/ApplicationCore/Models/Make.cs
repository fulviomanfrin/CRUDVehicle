using ApplicationCore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    internal class Make : BaseEntity
    {
        public string Name { get; private set; }
    }
}
