using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{
    internal class Dispatcher
    {
        private bool m_stateWeather;
        private List<Berth> m_pBerth = new List<Berth>();

        public Dispatcher(Hydrometeorologist hydrometeorologist) 
        {
            hydrometeorologist.attach(this);
            m_stateWeather = true;
        }

        public void addBerth(Berth berth) { m_pBerth.Add(berth); }                          // Добвление причала
        public void updateWeather(bool stateWeather) { m_stateWeather = stateWeather; }     // Обновление погодных условий
        public void clearBerths()                                                            // Освободить все причалы
        {
            for (int i = 0; i < m_pBerth.Count(); ++i)
            {
                if (m_pBerth[i].getShip() != null)
                    m_pBerth[i].sendShipToRaid();  // Надо добавить проверку чтобы это выполнялось один раз.
            }
        }
    }
}
