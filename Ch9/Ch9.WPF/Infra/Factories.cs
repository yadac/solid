using Ch9.WPF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ch9.WPF.Infra
{
    public class Factories
    {
        public static IMainWindowModelRepository CreateMainWindowModelRepository()
        {
            return new TaskStorage();
        }
    }
}
