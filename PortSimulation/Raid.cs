using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{
	internal class Raid
	{
		private LinkedList<Ship> m_pBulkCarriers;
		public LinkedList<Ship> m_pTankers { get; }
		private LinkedList<Ship> m_pGasCarriers;
		private LinkedList<Ship> m_pContainerCarriers;

		public Raid() 
		{
			m_pBulkCarriers = new LinkedList<Ship>();
			m_pTankers = new LinkedList<Ship>();
			m_pGasCarriers = new LinkedList<Ship>();
			m_pContainerCarriers = new LinkedList<Ship>();
		}

		public void Clear()
		{
			m_pBulkCarriers.Clear();
			m_pTankers.Clear();
			m_pGasCarriers.Clear();
			m_pContainerCarriers.Clear();
		}
		public void PutInQueue(Ship ship)
		{
			if (ship is BulkCarrier) m_pBulkCarriers.AddLast(ship);
			else if (ship is Tanker) m_pTankers.AddLast(ship);
			else if (ship is GasCarrier) m_pGasCarriers.AddLast(ship);
			else if (ship is ContainerCarrier) m_pContainerCarriers.AddLast(ship);
		}
		public void ReturnInQueue(Ship ship)
		{
			if (ship is BulkCarrier) m_pBulkCarriers.AddFirst(ship);
			else if (ship is Tanker) m_pTankers.AddFirst(ship);
			else if (ship is GasCarrier) m_pGasCarriers.AddFirst(ship);
			else if (ship is ContainerCarrier) m_pContainerCarriers.AddFirst(ship);
		}
		public Ship? MoveBulkCarrierShip()
		{
			if (m_pBulkCarriers.Count == 0) return null;
			Ship ship = m_pBulkCarriers.First!.Value;
			m_pBulkCarriers.RemoveFirst();
			return ship;
		}
		public Ship? MoveTankerShip()
		{
			if (m_pTankers.Count == 0) return null;
			Ship ship = m_pTankers.First!.Value;
			m_pTankers.RemoveFirst();
			return ship;
		}
		public Ship? MoveGasCarrierShip()
		{
			if (m_pGasCarriers.Count == 0) return null;
			Ship ship = m_pGasCarriers.First!.Value;
			m_pGasCarriers.RemoveFirst();
			return ship;
		}
		public Ship? MoveContainerCarrierShip()
		{
			if (m_pContainerCarriers.Count == 0) return null;
			Ship ship = m_pContainerCarriers.First!.Value;
			m_pContainerCarriers.RemoveFirst();
			return ship;
		}
		/*
		public void addBackBulkCarrier(Ship newShip) { m_pBulkCarriers.AddLast(newShip); }
		public void addBackTanker(Ship newShip) { m_pTankers.Add(newShip); }
		public void addBackGasCarrier(Ship newShip) { m_pGasCarriers.Add(newShip); }
		public void addBackContainerCarrier(Ship newShip) { m_pContainerCarriers.Add(newShip); }

		public void addFirstBulkCarrier(Ship newShip) { m_pBulkCarriers.Insert(0,newShip); }
		public void addFirstTanker(Ship newShip) { m_pTankers.Insert(0, newShip); }
		public void addFirstGasCarrier(Ship newShip) { m_pGasCarriers.Insert(0, newShip); }
		public void addFirstContainerCarrier(Ship newShip) { m_pContainerCarriers.Insert(0, newShip); }
		*/
	}
}
