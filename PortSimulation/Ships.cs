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
		protected int id;
		public static int Next { private get; set; } = 0;

		public Ship(ShipState state)
		{
			id = ++Next;
			State = state;
		}

		public void ChangeState()
		{
			if (State == ShipState.Loaded) State = ShipState.Unloaded;
			else if (State == ShipState.Unloaded) State = ShipState.Loaded;
		}

		public override string ToString()
		{
			return "Ship " + id;
		}
	}

	internal class BulkCarrier : Ship
	{
		public BulkCarrier(ShipState state) : base(state) { }

		public override string ToString()
		{
			return "BulkCarrier " + id;
		}
	}

	internal class Tanker : Ship
	{
		public Tanker(ShipState state) : base(state) { }

		public override string ToString()
		{
			return "Tanker " + id;
		}
	}

	internal class GasCarrier : Ship
	{
		public GasCarrier(ShipState state) : base(state) { }
		public override string ToString()
		{
			return "GasCarrier " + id;
		}
	}

	internal class ContainerCarrier : Ship
	{
		public ContainerCarrier(ShipState state) : base(state) { }
		public override string ToString()
		{
			return "ContainerCarrier " + id;
		}
	}
}
