using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurneraMision.models;

namespace TurneraMision.controllers
{
    class ctlTurnera
    {
        static ctlTurnera INSTANCE;
        public static ctlTurnera getInstance()
        {
            return INSTANCE != null ? INSTANCE : INSTANCE = new ctlTurnera();
        }

        private ctlTurnera() {

        }

        List<mTurno> ListaCirculos = new List<mTurno>();


        private mTurno busCircle(int circulo) {
            return ListaCirculos.FirstOrDefault(x => x.circle == circulo);
        }

        public void addCirculo(int circulo) {
            if (busCircle(circulo) == null)
                ListaCirculos.Add(new mTurno(circulo));
        }

        public void delCirculo(int circulo)
        {
            ListaCirculos.Remove(ListaCirculos.FirstOrDefault(x => x.circle == circulo));
        }

        public List<mTurno> getLista() {
            return ListaCirculos;
        }

        public void PuestoLibre(int puesto) {
            // Eliminamos el circulo q estaba antes en ese puesto.
            ListaCirculos.Remove(ListaCirculos.FirstOrDefault(x => x.getPuesto() == puesto));
            mTurno t = ListaCirculos.FirstOrDefault(x => x.getPuesto() == 0);
            if (t != null)
            {
                t.setPuesto(puesto);
            }
                
        }

    }
}
