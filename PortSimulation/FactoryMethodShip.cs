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
		Ship CreateShip(ShipState state);
	}

	internal class BulkCarrierFactory : IFactoryMethodShip
	{
		public Ship CreateShip(ShipState state) { return new BulkCarrier(state); }
	}

	internal class TankerFactory : IFactoryMethodShip
	{
		public Ship CreateShip(ShipState state) { return new Tanker(state); }
	}

	internal class GasCarriersFactory : IFactoryMethodShip
	{
		public Ship CreateShip(ShipState state) { return new GasCarrier(state); }
	}

	internal class ContainerCarriersFactory : IFactoryMethodShip
	{
		public Ship CreateShip(ShipState state) { return new ContainerCarrier(state); }
	}
}
