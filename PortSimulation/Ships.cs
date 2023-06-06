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
        protected ShipState m_state;
        protected Stratagy m_pStratagy;

        public Ship() { }
        public Ship(ShipState state,Stratagy stratagy) 
        {
            m_state = state;
            m_pStratagy = stratagy;
        }

        public void setState(ShipState state) { m_state = state; }
    }

    internal class BulkCarrierShip : Ship
    {
        public BulkCarrierShip(ShipState state, Stratagy stratagy) : base(state, stratagy) { }
    }

    internal class TankerShip : Ship
    {
        public TankerShip(ShipState state, Stratagy stratagy) : base(state, stratagy) { }
    }

    internal class GasCarriersShip : Ship
    {
        public GasCarriersShip(ShipState state, Stratagy stratagy) : base(state, stratagy) { }
    }

    internal class ContainerCarriersShip : Ship
    {
        public ContainerCarriersShip(ShipState state, Stratagy stratagy) : base(state, stratagy) { }
    }
}
