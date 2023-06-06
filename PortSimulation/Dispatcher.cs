using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{
	public delegate void Handler(string message);
	internal class Dispatcher
	{
		private List<Berth> berths = new List<Berth>();
		public Raid raid { get; } = new Raid();
		public bool WeatherIsClear { set => WeatherIsClear = value; }
		event Handler Notify;

		public Dispatcher(Hydrometeorologist hydrometeorologist) 
		{
			hydrometeorologist.Dispatcher = this;
		}

		public void AddBerth(Berth berth) { berths.Add(berth); }
		public void AddShip(Ship ship) { raid.PutInQueue(ship); }
		public void Manage()
		{
			foreach (Berth berth in berths)
			{
				if (berth.IsFree())
				{
					if (berth is BulkCarriersBerth)
					{
						berth.DockShip(raid.MoveBulkCarrierShip());
						berth.Service();
					}
					else if (berth is TankersBerth)
					{
						berth.DockShip(raid.MoveTankerShip());
						berth.Service();
					}
					else if (berth is GasCarriersBerth)
					{
						berth.DockShip(raid.MoveGasCarrierShip());
						berth.Service();
					}
					else if (berth is ContainerCarriersBerth)
					{
						berth.DockShip(raid.MoveContainerCarrierShip());
						berth.Service();
					}
				}
				else
				{
					if (berth.Ship!.State == ShipState.Loaded)
					{
						berth.MoorShip();
					}
					else
					{
						var rand = new Random();
						bool wait = rand.Next(2) == 0;
						Ship ship = berth.MoorShip()!;
						if (wait) raid.PutInQueue(ship);
					}
				}
			}
		}
	}
}
