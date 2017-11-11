using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurneraMision.controllers;

namespace TurneraMision
{
    public partial class frm_controlPanel : Form
    {

        frm_tv frmtv;
        int currCircle = 0;
        int puestosHabilitados = 10;

        public frm_controlPanel()
        {
            InitializeComponent();
        }

        private void frm_controlPanel_Load(object sender, EventArgs e)
        {
            frmtv = frm_tv.getForm();
            frmtv.Show();
            habilitarPuestos();
            txt_circulo.Focus();

            frmtv.showInMonitor(frm_tv.Monitor.Secundario);
        }

        private void habilitarPuestos() {
            FlowLayoutPanel flp;
            flp = (FlowLayoutPanel)splitContainer1.Panel2.Controls["PuestosLayaut"];
            flp.Controls.Clear();
            for (int i = 1; i < puestosHabilitados; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
                btn.Text = i.ToString();
                btn.Size = new Size(50, 50);
                btn.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                btn.Click += Btn_Click;
                btn.Tag = i;
                flp.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            ctlTurnera.getInstance().PuestoLibre((int)((Button)sender).Tag);
            frmtv.refreshGrid();
            frmtv.scrollToCaret();
            System.Media.SystemSounds.Exclamation.Play();
            txt_circulo.Focus();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (currCircle == 0) return;
            ctlTurnera.getInstance().addCirculo(currCircle);
            txt_circulo.Text = "";
            txt_circulo.Focus();
            frmtv.refreshGrid();
        }

        private void brn_eliminar_Click(object sender, EventArgs e)
        {
            if (currCircle == 0) return;
            ctlTurnera.getInstance().delCirculo(currCircle);
            txt_circulo.Text = "";
            txt_circulo.Focus();
            frmtv.refreshGrid();
        }

        private void txt_circulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;

            if (char.IsControl(e.KeyChar))
                e.Handled = false;

            if (e.KeyChar == (Char)13) {
                e.Handled = true;
                btn_agregar_Click(sender,null);
            }
        }

        private void txt_circulo_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_circulo.Text, out currCircle))
            {
                currCircle = 0;
            }
        }

        private void pantallaSecundariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtv.showInMonitor(frm_tv.Monitor.Secundario);
        }

        private void pantallaPrimariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtv.showInMonitor(frm_tv.Monitor.Primario);
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;

            if (char.IsControl(e.KeyChar))
                e.Handled = false;
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            int puestosNuevos;
            if (int.TryParse(toolStripTextBox1.Text, out puestosNuevos))
            {
                if (puestosNuevos != puestosHabilitados)
                {
                    puestosHabilitados = puestosNuevos;
                    habilitarPuestos();
                }
            }
        }
    }
}
