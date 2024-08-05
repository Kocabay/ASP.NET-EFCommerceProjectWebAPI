using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IDisplayEntity
    {
         bool IsDisplay {  get; set; }
         int DisplayOrder { get; set; }

    }
}
