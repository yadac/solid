﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    internal class NullUser : IUser
    {
        public string Name 
        { 
            get => "unknown"; 
            set => throw new NotImplementedException();
        }

        public void IncrementSessionTicket()
        {
            Console.WriteLine("nothing todo");
        }
    }
}
