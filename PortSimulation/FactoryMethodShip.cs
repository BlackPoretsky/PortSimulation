using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace PortSimulation
{
    internal interface IFactoryMethodShip
    {
        Ship createShip(ShipState state);
    }

    internal class BulkCarrierFactory : IFactoryMethodShip
    {
        public Ship createShip(ShipState state) { return new BulkCarrierShip(state); }
    }

    internal class TankerFactory : IFactoryMethodShip
    {
        public Ship createShip(ShipState state) { return new TankerShip(state); }
    }

    internal class GasCarriersFactory : IFactoryMethodShip
    {
        public Ship createShip(ShipState state) { return new GasCarriersShip(state); }
    }

    internal class ContainerCarriersFactory : IFactoryMethodShip
    {
        public Ship createShip(ShipState state) { return new ContainerCarriersShip(state); }
    }
}
