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
	}

	internal class BulkCarriersBerth : Berth { }

	internal class TankersBerth : Berth { }

	internal class GasCarriersBerth : Berth { }

	internal class ContainerCarriersBerth : Berth { }
}
