using Accessibility;
using PortSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace PortSimulation
{

    internal class Ship
    {
        public ShipState m_state { get; set; }

        public Ship(ShipState state) 
        {
            m_state = state;
        }
    }

    internal class BulkCarrierShip : Ship
    {
        public BulkCarrierShip(ShipState state) : base(state) { }
    }

    internal class TankerShip : Ship
    {
        public TankerShip(ShipState state) : base(state) { }
    }

    internal class GasCarriersShip : Ship
    {
        public GasCarriersShip(ShipState state) : base(state) { }
    }

    internal class ContainerCarriersShip : Ship
    {
        public ContainerCarriersShip(ShipState state) : base(state) { }
    }
}
