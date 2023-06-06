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
        Ship createShip(ShipState state, Stratagy stratagy);
    }

    internal class BulkCarrierFactory : IFactoryMethodShip
    {
        public Ship createShip(ShipState state, Stratagy stratagy) { return new BulkCarrierShip(state,stratagy); }
    }

    internal class TankerFactory : IFactoryMethodShip
    {
        public Ship createShip(ShipState state, Stratagy stratagy) { return new TankerShip(state, stratagy); }
    }

    internal class GasCarriersFactory : IFactoryMethodShip
    {
        public Ship createShip(ShipState state, Stratagy stratagy) { return new GasCarriersShip(state, stratagy); }
    }

    internal class ContainerCarriersFactory : IFactoryMethodShip
    {
        public Ship createShip(ShipState state, Stratagy stratagy) { return new ContainerCarriersShip(state, stratagy); }
    }
}
