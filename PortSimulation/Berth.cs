using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{        
	internal class Berth
	{
		public Ship? Ship { get; private set; } = null;
		protected int id;
		public static int Next { private get; set; } = 0;

		public Berth() { id = ++Next; }

		public void DockShip(Ship? ship) { this.Ship = ship; }
		public Ship? MoorShip()
		{
			Ship? ship = this.Ship;
			this.Ship = null;
			return ship;
		}
		public bool IsFree() { return Ship == null; }
		public void Service() 
		{	
			if (this.Ship != null) Ship.ChangeState(); 
		}
		public override string ToString()
		{
			return "Berth " + id;
		}
	}

	internal class BulkCarriersBerth : Berth 
	{
		public override string ToString()
		{
			return "BulkCarriersBerth " + id;
		}
	}

	internal class TankersBerth : Berth
	{
		public override string ToString()
		{
			return "TankersBerth " + id;
		}
	}

	internal class GasCarriersBerth : Berth
	{
		public override string ToString()
		{
			return "GasCarriersBerth " + id;
		}
	}

	internal class ContainerCarriersBerth : Berth
	{
		public override string ToString()
		{
			return "ContainerCarriersBerth " + id;
		}
	}
}
