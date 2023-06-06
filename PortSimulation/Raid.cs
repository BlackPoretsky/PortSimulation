using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{
    internal class Raid
    {
        private List<Ship> m_pBulkCarriers;
        private List<Ship> m_pTankers;
        private List<Ship> m_pGasCarriers;
        private List<Ship> m_pContainerCarriers;

        public Raid() 
        {
            m_pBulkCarriers = new List<Ship>();
            m_pTankers = new List<Ship>();
            m_pGasCarriers = new List<Ship>();
            m_pContainerCarriers = new List<Ship>();
        }

        public void addBackBulkCarrier(Ship newShip) { m_pBulkCarriers.Add(newShip); }
        public void addBackTanker(Ship newShip) { m_pTankers.Add(newShip); }
        public void addBackGasCarrier(Ship newShip) { m_pGasCarriers.Add(newShip); }
        public void addBackContainerCarrier(Ship newShip) { m_pContainerCarriers.Add(newShip); }

        public void addFirstBulkCarrier(Ship newShip) { m_pBulkCarriers.Insert(0,newShip); }
        public void addFirstTanker(Ship newShip) { m_pTankers.Insert(0, newShip); }
        public void addFirstGasCarrier(Ship newShip) { m_pGasCarriers.Insert(0, newShip); }
        public void addFirstContainerCarrier(Ship newShip) { m_pContainerCarriers.Insert(0, newShip); }

        public Ship getBulkCarrier() 
        {   
            Ship currentShip = m_pBulkCarriers[0];
            m_pBulkCarriers.RemoveAt(0);
            return currentShip; 
        }

        public Ship getTanker()
        {
            Ship currentShip = m_pTankers[0];
            m_pTankers.RemoveAt(0);
            return currentShip;
        }

        public Ship getGasCarrier()
        {
            Ship currentShip = m_pGasCarriers[0];
            m_pGasCarriers.RemoveAt(0);
            return currentShip;
        }

        public Ship getContainerCarrier()
        {
            Ship currentShip = m_pContainerCarriers[0];
            m_pContainerCarriers.RemoveAt(0);
            return currentShip;
        }
    }
}
