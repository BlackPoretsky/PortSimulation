using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{
    internal class Stratagy
    {
        protected Berth m_pBerth;
        
        public void setBerth(Berth berth) { m_pBerth = berth; }
        public virtual void shipControl() { }
    }

    internal class LoadGo : Stratagy
    {
        public override void shipControl() 
        {
            m_pBerth.load();
            m_pBerth.sendShipToSea();
        }
    }

    internal class UnloadGo : Stratagy
    {
        public override void shipControl()
        {
            m_pBerth.unload();
            m_pBerth.sendShipToSea();
        }
    }

    internal class UnloadLoadGo : Stratagy
    {
        public override void shipControl() // Надо дописать
        {
            m_pBerth.unload();
            m_pBerth.sendShipToRaid();
            m_pBerth.sendShipToSea();
        }
    }
}
