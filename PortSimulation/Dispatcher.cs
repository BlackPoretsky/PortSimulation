using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{
	public delegate void Handler(string? message);
	internal class Dispatcher
	{
		public List<Berth> Berths { get; } = new List<Berth>();
		public Raid raid { get; } = new Raid();
		public bool WeatherIsClear { private get; set; }
		public event Handler? Notify;

		public Dispatcher(Hydrometeorologist hydrometeorologist) 
		{
			hydrometeorologist.Dispatcher = this;
		}

		public void AddBerth(Berth berth) 
		{ 
			Berths.Add(berth);
			Notify!(berth.ToString() + " is ready to work");
		}
		public void AddShip(Ship ship) 
		{
			raid.PutInQueue(ship);
			Notify!(ship.ToString() + " arrived to the raid");
		}
		private string? MakeReport(Ship? ship, Berth berth)
		{
			if (ship == null) return null;
			string message = ship.ToString();
			if (ship.State == ShipState.Unloaded)
				message += " is unloaded at ";
			else
				message += " is loaded at ";
			return message + berth.ToString();
		}
		public void Manage()
		{
			foreach (Berth berth in Berths)
			{
				if (!WeatherIsClear)
				{
					Ship? ship = berth.MoorShip();
					if (ship != null)
					{
						raid.ReturnInQueue(ship);
						Notify!(ship.ToString() + " is returned to the raid");
					}
				}
				else if (berth.IsFree())
				{
					if (berth is BulkCarriersBerth)
					{
						berth.DockShip(raid.MoveBulkCarrierShip());
						berth.Service();
						Notify!(MakeReport(berth.Ship, berth));
					}
					else if (berth is TankersBerth)
					{
						berth.DockShip(raid.MoveTankerShip());
						berth.Service();
						Notify!(MakeReport(berth.Ship, berth));
					}
					else if (berth is GasCarriersBerth)
					{
						berth.DockShip(raid.MoveGasCarrierShip());
						berth.Service();
						Notify!(MakeReport(berth.Ship, berth));
					}
					else if (berth is ContainerCarriersBerth)
					{
						berth.DockShip(raid.MoveContainerCarrierShip());
						berth.Service();
						Notify!(MakeReport(berth.Ship, berth));
					}
				}
				else
				{
					if (berth.Ship!.State == ShipState.Loaded)
					{
						Ship ship = berth.MoorShip()!;
						Notify!(ship.ToString() + " has left the port");
					}
					else
					{
						var rand = new Random();
						bool wait = rand.Next(2) == 0;
						Ship ship = berth.MoorShip()!;
						string message = ship.ToString();
						if (wait)
						{
							raid.PutInQueue(ship);
							message += " moved to the raid";
						}
						else message += " has left the port";
						Notify!(message);
					}
				}
			}
		}
	}
}
