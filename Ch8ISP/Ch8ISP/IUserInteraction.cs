using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public interface IUserInteraction
    {
        bool Confirmation(string message);
    }
}
