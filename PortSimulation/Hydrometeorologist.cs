using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{
    internal class Hydrometeorologist
    {
        private bool m_stateWeather = true;
        private Dispatcher m_pDispatcher = null;
        private Random random = new Random();

        public void attach(Dispatcher dispatcher)
        {
            m_pDispatcher = dispatcher;
        }

        public void generateWeather() 
        {
            m_stateWeather = random.Next(2) == 0;
            m_pDispatcher.updateWeather(m_stateWeather);
        }
        
    }
}
