using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurneraMision.models
{
    class mTurno
    {
        public mTurno(int circle) {
            this.circle = circle;
        }
        public int circle { get; set; }

        private int _puesto;
        public String puesto
        {
            get { return _puesto == 0 ? "" : _puesto.ToString(); }
        }

        public int getPuesto()
        {
            return _puesto;
        }

        public void setPuesto(int p ) 
        {
            _puesto = p;
        }

    }
}
