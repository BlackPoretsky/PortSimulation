using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace PortSimulation
{        
    internal class Berth
    {
        protected Ship p_ship;

        public Berth()
        {
            p_ship = null;
        }

        public void unload() { p_ship.m_state = ShipState.Unload; } // Разгрузить корабль 
        public void load() { p_ship.m_state = ShipState.Load; }     // Загрузить корабль
        public void takeShip(Ship ship) { p_ship = ship; }          // Пришвартовать корабль
        public void sendShip() { p_ship = null; }                   // Отправить корабль
    }

    internal class BulkCarrierBerth : Berth
    {
        public BulkCarrierBerth()
        {
        }
    }

    internal class TankerShipBerth : Berth
    {
        public TankerShipBerth()
        {
        }
    }

    internal class GasCarriersBerth : Berth
    {
        public GasCarriersBerth()
        {
        }
    }

    internal class ContainerCarriersBerth : Berth
    {
        public ContainerCarriersBerth()
        {
        }
    }
}
