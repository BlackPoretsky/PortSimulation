using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{        
    internal class Berth
    {
        protected Berth m_pBerth;
        protected Ship m_pShip;
        protected static Raid m_raid;

        public Berth()
        {
            m_pBerth = this;
        }

        public Ship getShip() { return m_pShip; }
        public void setRaid(Raid raid) { m_raid = raid; }            // Установить рейд
        public void unload() { m_pShip.setState(ShipState.Unload); } // Разгрузить корабль 
        public void load() { m_pShip.setState(ShipState.Load); }     // Загрузить корабль
        public void sendShipToSea() { m_pShip = null; }              // Отправить корабль в Море
        public virtual void sendShipToRaid() { }                     // Отправить корабль в Рейд
        public virtual void setShip() { }                            // Пришвартовать корабль
    }

    internal class BulkCarrierBerth : Berth
    {
        public override void setShip() { m_pShip = m_raid.getBulkCarrier(); }
        public override void sendShipToRaid() 
        { 
            m_raid.addFirstBulkCarrier(m_pShip);
            m_pShip = null;
        }
    }

    internal class TankerShipBerth : Berth
    {
        public override void setShip() { m_pShip = m_raid.getTanker(); }
        public override void sendShipToRaid()
        {
            m_raid.addFirstBulkCarrier(m_pShip);
            m_pShip = null;
        }
    }

    internal class GasCarriersBerth : Berth
    {
        public override void setShip() { m_pShip = m_raid.getGasCarrier(); }
        public override void sendShipToRaid()
        {
            m_raid.addFirstBulkCarrier(m_pShip);
            m_pShip = null;
        }
    }

    internal class ContainerCarriersBerth : Berth
    {
        public override void setShip() { m_pShip = m_raid.getContainerCarrier(); }
        public override void sendShipToRaid()
        {
            m_raid.addFirstBulkCarrier(m_pShip);
            m_pShip = null;
        }
    }
}
