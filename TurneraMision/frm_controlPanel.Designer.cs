namespace TurneraMision
{
    partial class frm_controlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaSecundariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaPrimariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.brn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_circle = new System.Windows.Forms.Label();
            this.txt_circulo = new System.Windows.Forms.TextBox();
            this.PuestosLayaut = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 281);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(659, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.puestosToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaSecundariaToolStripMenuItem,
            this.pantallaPrimariaToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.abrirToolStripMenuItem.Text = "Turnera";
            // 
            // pantallaSecundariaToolStripMenuItem
            // 
            this.pantallaSecundariaToolStripMenuItem.Name = "pantallaSecundariaToolStripMenuItem";
            this.pantallaSecundariaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pantallaSecundariaToolStripMenuItem.Text = "Pantalla Secundaria";
            this.pantallaSecundariaToolStripMenuItem.Click += new System.EventHandler(this.pantallaSecundariaToolStripMenuItem_Click);
            // 
            // pantallaPrimariaToolStripMenuItem
            // 
            this.pantallaPrimariaToolStripMenuItem.Name = "pantallaPrimariaToolStripMenuItem";
            this.pantallaPrimariaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pantallaPrimariaToolStripMenuItem.Text = "Pantalla Primaria";
            this.pantallaPrimariaToolStripMenuItem.Click += new System.EventHandler(this.pantallaPrimariaToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.puestosToolStripMenuItem.Text = "Puestos:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.MaxLength = 2;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "10";
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.brn_eliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_agregar);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_circle);
            this.splitContainer1.Panel1.Controls.Add(this.txt_circulo);
            this.splitContainer1.Panel1MinSize = 220;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PuestosLayaut);
            this.splitContainer1.Panel2MinSize = 400;
            this.splitContainer1.Size = new System.Drawing.Size(659, 254);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 2;
            // 
            // brn_eliminar
            // 
            this.brn_eliminar.Location = new System.Drawing.Point(128, 103);
            this.brn_eliminar.Name = "brn_eliminar";
            this.brn_eliminar.Size = new System.Drawing.Size(75, 35);
            this.brn_eliminar.TabIndex = 3;
            this.brn_eliminar.Text = "Eliminar";
            this.brn_eliminar.UseVisualStyleBackColor = true;
            this.brn_eliminar.Click += new System.EventHandler(this.brn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 103);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 35);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_circle
            // 
            this.lbl_circle.AutoSize = true;
            this.lbl_circle.Location = new System.Drawing.Point(13, 27);
            this.lbl_circle.Name = "lbl_circle";
            this.lbl_circle.Size = new System.Drawing.Size(77, 13);
            this.lbl_circle.TabIndex = 1;
            this.lbl_circle.Text = "Ingrese Circulo";
            // 
            // txt_circulo
            // 
            this.txt_circulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_circulo.Location = new System.Drawing.Point(12, 46);
            this.txt_circulo.MaxLength = 6;
            this.txt_circulo.Name = "txt_circulo";
            this.txt_circulo.Size = new System.Drawing.Size(191, 44);
            this.txt_circulo.TabIndex = 0;
            this.txt_circulo.TextChanged += new System.EventHandler(this.txt_circulo_TextChanged);
            this.txt_circulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_circulo_KeyPress);
            // 
            // PuestosLayaut
            // 
            this.PuestosLayaut.BackColor = System.Drawing.Color.White;
            this.PuestosLayaut.BackgroundImage = global::TurneraMision.Properties.Resources.logoHeader_1f565276cbeac991be9ba1fdcd4dc880;
            this.PuestosLayaut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PuestosLayaut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PuestosLayaut.Location = new System.Drawing.Point(0, 0);
            this.PuestosLayaut.Name = "PuestosLayaut";
            this.PuestosLayaut.Size = new System.Drawing.Size(435, 254);
            this.PuestosLayaut.TabIndex = 0;
            // 
            // frm_controlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 303);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(675, 342);
            this.Name = "frm_controlPanel";
            this.ShowIcon = false;
            this.Text = "Panel de Control TURNOS";
            this.Load += new System.EventHandler(this.frm_controlPanel_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel PuestosLayaut;
        private System.Windows.Forms.Button brn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_circle;
        private System.Windows.Forms.TextBox txt_circulo;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaSecundariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaPrimariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}