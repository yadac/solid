using Ch9.WPF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9.WPF.Infra
{
    internal class TaskStorage : IMainWindowModelRepository
    {
        public string Value1 { get; set; } = string.Empty;
        public string Value2 { get; set; } = string.Empty;
    }
}
