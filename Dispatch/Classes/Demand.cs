﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch.Classes
{
    public class Demand
    {
        private Address address = new Address();
        private UInt16 weight;
        private string weight_UOM = "percentage";
        public enum Pickup { Inbound, Outbound, Inbound_Outbound};
        //so inbound = 0, outbound = 1; inbound_outbound = 2;

    }
}
