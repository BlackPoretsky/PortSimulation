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
		public ShipState State { get; private set; }

		public Ship(ShipState state) { State = state; }

		public void ChangeState()
		{
			if (State == ShipState.Loaded) State = ShipState.Unloaded;
			else if (State == ShipState.Unloaded) State = ShipState.Loaded;
		}
	}

	internal class BulkCarrier : Ship
	{
		public BulkCarrier(ShipState state) : base(state) { }
	}

	internal class Tanker : Ship
	{
		public Tanker(ShipState state) : base(state) { }
	}

	internal class GasCarrier : Ship
	{
		public GasCarrier(ShipState state) : base(state) { }
	}

	internal class ContainerCarrier : Ship
	{
		public ContainerCarrier(ShipState state) : base(state) { }
	}
}
