using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juventus.AcercaDeNosotros
{
    public partial class AcercaNos : Form
    {
        private string info = "Ateneo Juventus es una asociación civil sin fines de lucro (Asociación Civil Ateneo Juventus - Cuit 30-71053858-8),\n que tiene por objetivo la formación de jóvenes dirigentes cristianos, al estilo de Jesús,\n para que vivan y transmitan el Evangelio siendo “sal y luz” en el mundo, en su ámbito natural de acción." +
            "\n Fue Fundado por el Padre Capuchino Carmelo d´Agostino\n el 26 de Abril de 1958. Hoy, a pesar del fallecimiento de su fundador,\n la Institución sigue contando con miles de ateneístas que están comprometidos en el sostenimiento de este espacio,\n que permite a los adolescentes formar su proyecto personal de vida aprendiendo a caminar con Dios en su vida, acompañados de otros jóvenes,\n vacuna eficaz contra el vacío y la soledad." +
            "El proceso formativo comienza desde muy temprano y de\n diferentes maneras participan chicos desde 4º grado hasta la Universidad\n y nos acompaña luego durante toda nuestra vida.Son los mismos chicos quienes van asumiendo, al crecer,\n el rol de formadores de quienes ingresan,\n y participan más tarde como padres respaldando el trabajo de los jefes." +
            "\n Una parte importante de la formación de los jóvenes consiste en la acción social y la ayuda al prójimo.\n Desde hace unos años Ateneo trabaja de forma activa y permanente en distintos barrios de la ciudad, asilos, hogares, etc";

        public AcercaNos()
        {
            InitializeComponent();
        }

        private void AcercaNos_Load(object sender, EventArgs e)
        {
            lblInfo.Text = info;
        }
    }
}
