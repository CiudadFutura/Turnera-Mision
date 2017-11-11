using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using WMPLib;
using AxWMPLib;
using TurneraMision.controllers;


namespace TurneraMision
{
    public partial class frm_tv : Form
    {
        private static frm_tv INSTANCE = null;
        public static frm_tv getForm() {
            return INSTANCE != null ? INSTANCE : INSTANCE = new frm_tv();
        }
        AxWindowsMediaPlayer myWmp;

        public enum Monitor : int {
            Primario = 0,
            Secundario = 1
        }

        public void showInMonitor(Monitor num) {
            Screen[] monitores = Screen.AllScreens;
            if (monitores.Length <= (int)num) {
                return;
            }
            this.Hide();
            float prevW = this.Width;
            float prevH = this.Height;
            if (num == Monitor.Secundario)
            {
                this.StartPosition = FormStartPosition.Manual;
                Point p = new Point(monitores[(int)num].Bounds.Location.X, 0);
                this.Location = p;
                this.FormBorderStyle = FormBorderStyle.None;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
            else {
                this.StartPosition = FormStartPosition.CenterScreen;
                Point p = new Point(monitores[(int)num].Bounds.Location.X, 0);
                this.Location = p;
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.MaximizeBox = true;
                this.MinimizeBox = true;
            }
            this.WindowState = FormWindowState.Maximized;
            this.Scale(new SizeF(monitores[(int)num].Bounds.Size.Width / prevW, monitores[(int)num].Bounds.Size.Width / prevH));
            Font myFont = this.dgv_turnos.ColumnHeadersDefaultCellStyle.Font;
            myFont = new Font(myFont.FontFamily, myFont.Size * monitores[(int)num].Bounds.Size.Width / prevW, myFont.Style);
            this.dgv_turnos.ColumnHeadersDefaultCellStyle.Font = myFont;
            this.dgv_turnos.DefaultCellStyle.Font = myFont;
            this.Show();
        }

        

        private frm_tv()
        {
            
            InitializeComponent();

            System.Windows.Forms.DataGridViewCellStyle dgsS = new System.Windows.Forms.DataGridViewCellStyle();
            dgsS.Font =new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgsS.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgsS.BackColor = System.Drawing.Color.White;
            dgsS.ForeColor = System.Drawing.Color.Red;
            dgsS.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dgsS.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgsS.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turnos.ColumnHeadersDefaultCellStyle = dgsS;
            this.dgv_turnos.DefaultCellStyle = dgsS;
            this.dgv_turnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.FormBorderStyle = FormBorderStyle.None;
            myWmp = (AxWindowsMediaPlayer)splitContainer1.Panel2.Controls["wmp"];
            myWmp.enableContextMenu = false;
            myWmp.Ctlenabled = false;
            myWmp.stretchToFit = true;
            myWmp.uiMode = "none"; // "invisible" "none" "mini" "full"            
            myWmp.PlayStateChange += Wmp_PlayStateChange;
            myWmp.settings.mute = true;
            dgv_turnos.Enabled = false;
            dgv_turnos.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgv_turnos.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            refreshGrid();

        }

        public void refreshGrid() {
            dgv_turnos.DataSource = null;
            dgv_turnos.DataSource = ctlTurnera.getInstance().getLista();
        }

        public void scrollToCaret() {
            if (dgv_turnos.RowCount > 3)
                dgv_turnos.FirstDisplayedScrollingRowIndex = dgv_turnos.RowCount - 1;
        }

        private void Wmp_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1) // Si se detuvo vuelve a empezar.
                myWmp.Ctlcontrols.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String mediaPath = Directory.GetCurrentDirectory() + "\\media";
            if (!Directory.Exists(mediaPath)) { Directory.CreateDirectory(mediaPath); }

            foreach (string item in Directory.EnumerateFiles(mediaPath))
            {
                IWMPMedia nueva = myWmp.newMedia(item);
                myWmp.currentPlaylist.appendItem(nueva);
                Console.WriteLine("Files {0}", item);
            }
            myWmp.Ctlcontrols.play();
        }

      
    }
}
