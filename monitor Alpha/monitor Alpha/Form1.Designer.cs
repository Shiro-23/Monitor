﻿namespace monitor_Alpha
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.grp_Servicios = new System.Windows.Forms.GroupBox();
            this.tbl_Servicios = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ServicioEmail = new System.Windows.Forms.Label();
            this.lbl_ServicioReplicaCD = new System.Windows.Forms.Label();
            this.lbl_ServicioWMSSAP = new System.Windows.Forms.Label();
            this.lbl_ServicioInfo = new System.Windows.Forms.Label();
            this.lbl_ServicioWMSOleada = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_ServidorWMSEmail = new System.Windows.Forms.Label();
            this.lbl_ServidorWMSReplica = new System.Windows.Forms.Label();
            this.lbl_ServidorWMSWMSSAP = new System.Windows.Forms.Label();
            this.lbl_ServidorIntegracionesServInfo = new System.Windows.Forms.Label();
            this.lbl_ServidorPickingWMSOleada = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pic_EstadoServicioEmail = new System.Windows.Forms.PictureBox();
            this.pic_EstadoServicioReplica = new System.Windows.Forms.PictureBox();
            this.pic_EstadoServicioWMSSAP = new System.Windows.Forms.PictureBox();
            this.pic_EstadoServicioServInfo = new System.Windows.Forms.PictureBox();
            this.pic_EstadoServicioWMSOleada = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.grp_TablasLog = new System.Windows.Forms.GroupBox();
            this.tab_TablasLog = new System.Windows.Forms.TabControl();
            this.tabp_LogServicoEmail = new System.Windows.Forms.TabPage();
            this.grdv_LogServicioEmail = new System.Windows.Forms.DataGridView();
            this.tabp_LogServicioReplicaCD = new System.Windows.Forms.TabPage();
            this.grdv_LogServicioReplicaCD = new System.Windows.Forms.DataGridView();
            this.tabp_LogServicioWMSSAP = new System.Windows.Forms.TabPage();
            this.grdv_LogServicioWMSSAP = new System.Windows.Forms.DataGridView();
            this.tabp_LogServicioServInfo = new System.Windows.Forms.TabPage();
            this.grdv_LogServicioServInfo = new System.Windows.Forms.DataGridView();
            this.tabp_LogServicioWMSOleada = new System.Windows.Forms.TabPage();
            this.grdv_LogServicioWMSOleada = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grp_Filtro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdo_Ultimos1000Errores = new System.Windows.Forms.RadioButton();
            this.rdo_ErroresUltimas24Hrs = new System.Windows.Forms.RadioButton();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grp_Servicios.SuspendLayout();
            this.tbl_Servicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioReplica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioWMSSAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioServInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioWMSOleada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.grp_TablasLog.SuspendLayout();
            this.tab_TablasLog.SuspendLayout();
            this.tabp_LogServicoEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioEmail)).BeginInit();
            this.tabp_LogServicioReplicaCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioReplicaCD)).BeginInit();
            this.tabp_LogServicioWMSSAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioWMSSAP)).BeginInit();
            this.tabp_LogServicioServInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioServInfo)).BeginInit();
            this.tabp_LogServicioWMSOleada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioWMSOleada)).BeginInit();
            this.grp_Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(603, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DoubleClickEnabled = true;
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Extraer";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel2.Text = "Cerrar";
            // 
            // grp_Servicios
            // 
            this.grp_Servicios.Controls.Add(this.tbl_Servicios);
            this.grp_Servicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Servicios.Location = new System.Drawing.Point(0, 50);
            this.grp_Servicios.Name = "grp_Servicios";
            this.grp_Servicios.Size = new System.Drawing.Size(609, 183);
            this.grp_Servicios.TabIndex = 1;
            this.grp_Servicios.TabStop = false;
            this.grp_Servicios.Text = "Estado de servicios";
            // 
            // tbl_Servicios
            // 
            this.tbl_Servicios.ColumnCount = 3;
            this.tbl_Servicios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tbl_Servicios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tbl_Servicios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tbl_Servicios.Controls.Add(this.lbl_ServicioEmail, 0, 0);
            this.tbl_Servicios.Controls.Add(this.lbl_ServicioReplicaCD, 0, 1);
            this.tbl_Servicios.Controls.Add(this.lbl_ServicioWMSSAP, 0, 2);
            this.tbl_Servicios.Controls.Add(this.lbl_ServicioInfo, 0, 3);
            this.tbl_Servicios.Controls.Add(this.lbl_ServicioWMSOleada, 0, 4);
            this.tbl_Servicios.Controls.Add(this.label6, 0, 5);
            this.tbl_Servicios.Controls.Add(this.lbl_ServidorWMSEmail, 1, 0);
            this.tbl_Servicios.Controls.Add(this.lbl_ServidorWMSReplica, 1, 1);
            this.tbl_Servicios.Controls.Add(this.lbl_ServidorWMSWMSSAP, 1, 2);
            this.tbl_Servicios.Controls.Add(this.lbl_ServidorIntegracionesServInfo, 1, 3);
            this.tbl_Servicios.Controls.Add(this.lbl_ServidorPickingWMSOleada, 1, 4);
            this.tbl_Servicios.Controls.Add(this.label12, 1, 5);
            this.tbl_Servicios.Controls.Add(this.pic_EstadoServicioEmail, 2, 0);
            this.tbl_Servicios.Controls.Add(this.pic_EstadoServicioReplica, 2, 1);
            this.tbl_Servicios.Controls.Add(this.pic_EstadoServicioWMSSAP, 2, 2);
            this.tbl_Servicios.Controls.Add(this.pic_EstadoServicioServInfo, 2, 3);
            this.tbl_Servicios.Controls.Add(this.pic_EstadoServicioWMSOleada, 2, 4);
            this.tbl_Servicios.Controls.Add(this.pictureBox6, 2, 5);
            this.tbl_Servicios.Location = new System.Drawing.Point(12, 19);
            this.tbl_Servicios.Name = "tbl_Servicios";
            this.tbl_Servicios.RowCount = 6;
            this.tbl_Servicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.08861F));
            this.tbl_Servicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.82278F));
            this.tbl_Servicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Servicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Servicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Servicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Servicios.Size = new System.Drawing.Size(533, 158);
            this.tbl_Servicios.TabIndex = 0;
            // 
            // lbl_ServicioEmail
            // 
            this.lbl_ServicioEmail.AutoSize = true;
            this.lbl_ServicioEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServicioEmail.Location = new System.Drawing.Point(3, 0);
            this.lbl_ServicioEmail.Name = "lbl_ServicioEmail";
            this.lbl_ServicioEmail.Size = new System.Drawing.Size(138, 20);
            this.lbl_ServicioEmail.TabIndex = 0;
            this.lbl_ServicioEmail.Text = "Servicio Emails.";
            // 
            // lbl_ServicioReplicaCD
            // 
            this.lbl_ServicioReplicaCD.AutoSize = true;
            this.lbl_ServicioReplicaCD.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServicioReplicaCD.Location = new System.Drawing.Point(3, 27);
            this.lbl_ServicioReplicaCD.Name = "lbl_ServicioReplicaCD";
            this.lbl_ServicioReplicaCD.Size = new System.Drawing.Size(166, 20);
            this.lbl_ServicioReplicaCD.TabIndex = 1;
            this.lbl_ServicioReplicaCD.Text = "Servicio Replica CD";
            // 
            // lbl_ServicioWMSSAP
            // 
            this.lbl_ServicioWMSSAP.AutoSize = true;
            this.lbl_ServicioWMSSAP.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServicioWMSSAP.Location = new System.Drawing.Point(3, 52);
            this.lbl_ServicioWMSSAP.Name = "lbl_ServicioWMSSAP";
            this.lbl_ServicioWMSSAP.Size = new System.Drawing.Size(155, 20);
            this.lbl_ServicioWMSSAP.TabIndex = 2;
            this.lbl_ServicioWMSSAP.Text = "Servicio WMS SAP";
            // 
            // lbl_ServicioInfo
            // 
            this.lbl_ServicioInfo.AutoSize = true;
            this.lbl_ServicioInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServicioInfo.Location = new System.Drawing.Point(3, 78);
            this.lbl_ServicioInfo.Name = "lbl_ServicioInfo";
            this.lbl_ServicioInfo.Size = new System.Drawing.Size(146, 20);
            this.lbl_ServicioInfo.TabIndex = 3;
            this.lbl_ServicioInfo.Text = "Servicio ServInfo";
            // 
            // lbl_ServicioWMSOleada
            // 
            this.lbl_ServicioWMSOleada.AutoSize = true;
            this.lbl_ServicioWMSOleada.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServicioWMSOleada.Location = new System.Drawing.Point(3, 104);
            this.lbl_ServicioWMSOleada.Name = "lbl_ServicioWMSOleada";
            this.lbl_ServicioWMSOleada.Size = new System.Drawing.Size(177, 20);
            this.lbl_ServicioWMSOleada.TabIndex = 4;
            this.lbl_ServicioWMSOleada.Text = "Servico WMS Oleada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "XXX";
            // 
            // lbl_ServidorWMSEmail
            // 
            this.lbl_ServidorWMSEmail.AutoSize = true;
            this.lbl_ServidorWMSEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServidorWMSEmail.Location = new System.Drawing.Point(233, 0);
            this.lbl_ServidorWMSEmail.Name = "lbl_ServidorWMSEmail";
            this.lbl_ServidorWMSEmail.Size = new System.Drawing.Size(121, 20);
            this.lbl_ServidorWMSEmail.TabIndex = 6;
            this.lbl_ServidorWMSEmail.Text = "Servidor WMS";
            // 
            // lbl_ServidorWMSReplica
            // 
            this.lbl_ServidorWMSReplica.AutoSize = true;
            this.lbl_ServidorWMSReplica.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServidorWMSReplica.Location = new System.Drawing.Point(233, 27);
            this.lbl_ServidorWMSReplica.Name = "lbl_ServidorWMSReplica";
            this.lbl_ServidorWMSReplica.Size = new System.Drawing.Size(121, 20);
            this.lbl_ServidorWMSReplica.TabIndex = 7;
            this.lbl_ServidorWMSReplica.Text = "Servidor WMS";
            // 
            // lbl_ServidorWMSWMSSAP
            // 
            this.lbl_ServidorWMSWMSSAP.AutoSize = true;
            this.lbl_ServidorWMSWMSSAP.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServidorWMSWMSSAP.Location = new System.Drawing.Point(233, 52);
            this.lbl_ServidorWMSWMSSAP.Name = "lbl_ServidorWMSWMSSAP";
            this.lbl_ServidorWMSWMSSAP.Size = new System.Drawing.Size(121, 20);
            this.lbl_ServidorWMSWMSSAP.TabIndex = 8;
            this.lbl_ServidorWMSWMSSAP.Text = "Servidor WMS";
            // 
            // lbl_ServidorIntegracionesServInfo
            // 
            this.lbl_ServidorIntegracionesServInfo.AutoSize = true;
            this.lbl_ServidorIntegracionesServInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServidorIntegracionesServInfo.Location = new System.Drawing.Point(233, 78);
            this.lbl_ServidorIntegracionesServInfo.Name = "lbl_ServidorIntegracionesServInfo";
            this.lbl_ServidorIntegracionesServInfo.Size = new System.Drawing.Size(193, 20);
            this.lbl_ServidorIntegracionesServInfo.TabIndex = 9;
            this.lbl_ServidorIntegracionesServInfo.Text = "Servidor Integraciones";
            // 
            // lbl_ServidorPickingWMSOleada
            // 
            this.lbl_ServidorPickingWMSOleada.AutoSize = true;
            this.lbl_ServidorPickingWMSOleada.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServidorPickingWMSOleada.Location = new System.Drawing.Point(233, 104);
            this.lbl_ServidorPickingWMSOleada.Name = "lbl_ServidorPickingWMSOleada";
            this.lbl_ServidorPickingWMSOleada.Size = new System.Drawing.Size(138, 20);
            this.lbl_ServidorPickingWMSOleada.TabIndex = 10;
            this.lbl_ServidorPickingWMSOleada.Text = "Servidor Picking";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(233, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Servidor FTP";
            // 
            // pic_EstadoServicioEmail
            // 
            this.pic_EstadoServicioEmail.Location = new System.Drawing.Point(477, 3);
            this.pic_EstadoServicioEmail.Name = "pic_EstadoServicioEmail";
            this.pic_EstadoServicioEmail.Size = new System.Drawing.Size(27, 21);
            this.pic_EstadoServicioEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_EstadoServicioEmail.TabIndex = 12;
            this.pic_EstadoServicioEmail.TabStop = false;
            // 
            // pic_EstadoServicioReplica
            // 
            this.pic_EstadoServicioReplica.Location = new System.Drawing.Point(477, 30);
            this.pic_EstadoServicioReplica.Name = "pic_EstadoServicioReplica";
            this.pic_EstadoServicioReplica.Size = new System.Drawing.Size(27, 19);
            this.pic_EstadoServicioReplica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_EstadoServicioReplica.TabIndex = 13;
            this.pic_EstadoServicioReplica.TabStop = false;
            // 
            // pic_EstadoServicioWMSSAP
            // 
            this.pic_EstadoServicioWMSSAP.Location = new System.Drawing.Point(477, 55);
            this.pic_EstadoServicioWMSSAP.Name = "pic_EstadoServicioWMSSAP";
            this.pic_EstadoServicioWMSSAP.Size = new System.Drawing.Size(27, 20);
            this.pic_EstadoServicioWMSSAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_EstadoServicioWMSSAP.TabIndex = 14;
            this.pic_EstadoServicioWMSSAP.TabStop = false;
            // 
            // pic_EstadoServicioServInfo
            // 
            this.pic_EstadoServicioServInfo.Location = new System.Drawing.Point(477, 81);
            this.pic_EstadoServicioServInfo.Name = "pic_EstadoServicioServInfo";
            this.pic_EstadoServicioServInfo.Size = new System.Drawing.Size(27, 20);
            this.pic_EstadoServicioServInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_EstadoServicioServInfo.TabIndex = 15;
            this.pic_EstadoServicioServInfo.TabStop = false;
            // 
            // pic_EstadoServicioWMSOleada
            // 
            this.pic_EstadoServicioWMSOleada.Location = new System.Drawing.Point(477, 107);
            this.pic_EstadoServicioWMSOleada.Name = "pic_EstadoServicioWMSOleada";
            this.pic_EstadoServicioWMSOleada.Size = new System.Drawing.Size(27, 20);
            this.pic_EstadoServicioWMSOleada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_EstadoServicioWMSOleada.TabIndex = 16;
            this.pic_EstadoServicioWMSOleada.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(477, 133);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // grp_TablasLog
            // 
            this.grp_TablasLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_TablasLog.Controls.Add(this.tab_TablasLog);
            this.grp_TablasLog.Location = new System.Drawing.Point(0, 292);
            this.grp_TablasLog.Name = "grp_TablasLog";
            this.grp_TablasLog.Size = new System.Drawing.Size(609, 244);
            this.grp_TablasLog.TabIndex = 2;
            this.grp_TablasLog.TabStop = false;
            this.grp_TablasLog.Text = "Tablas Log";
            // 
            // tab_TablasLog
            // 
            this.tab_TablasLog.Controls.Add(this.tabp_LogServicoEmail);
            this.tab_TablasLog.Controls.Add(this.tabp_LogServicioReplicaCD);
            this.tab_TablasLog.Controls.Add(this.tabp_LogServicioWMSSAP);
            this.tab_TablasLog.Controls.Add(this.tabp_LogServicioServInfo);
            this.tab_TablasLog.Controls.Add(this.tabp_LogServicioWMSOleada);
            this.tab_TablasLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_TablasLog.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_TablasLog.Location = new System.Drawing.Point(3, 16);
            this.tab_TablasLog.Name = "tab_TablasLog";
            this.tab_TablasLog.SelectedIndex = 0;
            this.tab_TablasLog.Size = new System.Drawing.Size(603, 225);
            this.tab_TablasLog.TabIndex = 0;
            // 
            // tabp_LogServicoEmail
            // 
            this.tabp_LogServicoEmail.Controls.Add(this.grdv_LogServicioEmail);
            this.tabp_LogServicoEmail.Location = new System.Drawing.Point(4, 29);
            this.tabp_LogServicoEmail.Name = "tabp_LogServicoEmail";
            this.tabp_LogServicoEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_LogServicoEmail.Size = new System.Drawing.Size(595, 192);
            this.tabp_LogServicoEmail.TabIndex = 0;
            this.tabp_LogServicoEmail.Text = "Log Servicio Email";
            this.tabp_LogServicoEmail.UseVisualStyleBackColor = true;
            // 
            // grdv_LogServicioEmail
            // 
            this.grdv_LogServicioEmail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdv_LogServicioEmail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdv_LogServicioEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdv_LogServicioEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdv_LogServicioEmail.Location = new System.Drawing.Point(3, 3);
            this.grdv_LogServicioEmail.Name = "grdv_LogServicioEmail";
            this.grdv_LogServicioEmail.Size = new System.Drawing.Size(589, 186);
            this.grdv_LogServicioEmail.TabIndex = 0;
            // 
            // tabp_LogServicioReplicaCD
            // 
            this.tabp_LogServicioReplicaCD.Controls.Add(this.grdv_LogServicioReplicaCD);
            this.tabp_LogServicioReplicaCD.Location = new System.Drawing.Point(4, 29);
            this.tabp_LogServicioReplicaCD.Name = "tabp_LogServicioReplicaCD";
            this.tabp_LogServicioReplicaCD.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_LogServicioReplicaCD.Size = new System.Drawing.Size(595, 192);
            this.tabp_LogServicioReplicaCD.TabIndex = 1;
            this.tabp_LogServicioReplicaCD.Text = "Log Servicio Replica CD";
            this.tabp_LogServicioReplicaCD.UseVisualStyleBackColor = true;
            // 
            // grdv_LogServicioReplicaCD
            // 
            this.grdv_LogServicioReplicaCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdv_LogServicioReplicaCD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdv_LogServicioReplicaCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdv_LogServicioReplicaCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdv_LogServicioReplicaCD.Location = new System.Drawing.Point(3, 3);
            this.grdv_LogServicioReplicaCD.Name = "grdv_LogServicioReplicaCD";
            this.grdv_LogServicioReplicaCD.Size = new System.Drawing.Size(589, 186);
            this.grdv_LogServicioReplicaCD.TabIndex = 0;
            // 
            // tabp_LogServicioWMSSAP
            // 
            this.tabp_LogServicioWMSSAP.Controls.Add(this.grdv_LogServicioWMSSAP);
            this.tabp_LogServicioWMSSAP.Location = new System.Drawing.Point(4, 29);
            this.tabp_LogServicioWMSSAP.Name = "tabp_LogServicioWMSSAP";
            this.tabp_LogServicioWMSSAP.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_LogServicioWMSSAP.Size = new System.Drawing.Size(595, 192);
            this.tabp_LogServicioWMSSAP.TabIndex = 2;
            this.tabp_LogServicioWMSSAP.Text = "Log Servicio WMS SAP";
            this.tabp_LogServicioWMSSAP.UseVisualStyleBackColor = true;
            // 
            // grdv_LogServicioWMSSAP
            // 
            this.grdv_LogServicioWMSSAP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdv_LogServicioWMSSAP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdv_LogServicioWMSSAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdv_LogServicioWMSSAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdv_LogServicioWMSSAP.Location = new System.Drawing.Point(3, 3);
            this.grdv_LogServicioWMSSAP.Name = "grdv_LogServicioWMSSAP";
            this.grdv_LogServicioWMSSAP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdv_LogServicioWMSSAP.Size = new System.Drawing.Size(589, 186);
            this.grdv_LogServicioWMSSAP.TabIndex = 0;
            this.grdv_LogServicioWMSSAP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdv_LogServicioWMSSAP_CellClick);
            // 
            // tabp_LogServicioServInfo
            // 
            this.tabp_LogServicioServInfo.Controls.Add(this.grdv_LogServicioServInfo);
            this.tabp_LogServicioServInfo.Location = new System.Drawing.Point(4, 29);
            this.tabp_LogServicioServInfo.Name = "tabp_LogServicioServInfo";
            this.tabp_LogServicioServInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_LogServicioServInfo.Size = new System.Drawing.Size(595, 192);
            this.tabp_LogServicioServInfo.TabIndex = 3;
            this.tabp_LogServicioServInfo.Text = "Log Servicio ServInfo";
            this.tabp_LogServicioServInfo.UseVisualStyleBackColor = true;
            // 
            // grdv_LogServicioServInfo
            // 
            this.grdv_LogServicioServInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdv_LogServicioServInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdv_LogServicioServInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdv_LogServicioServInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdv_LogServicioServInfo.Location = new System.Drawing.Point(3, 3);
            this.grdv_LogServicioServInfo.Name = "grdv_LogServicioServInfo";
            this.grdv_LogServicioServInfo.Size = new System.Drawing.Size(589, 186);
            this.grdv_LogServicioServInfo.TabIndex = 0;
            // 
            // tabp_LogServicioWMSOleada
            // 
            this.tabp_LogServicioWMSOleada.Controls.Add(this.grdv_LogServicioWMSOleada);
            this.tabp_LogServicioWMSOleada.Location = new System.Drawing.Point(4, 29);
            this.tabp_LogServicioWMSOleada.Name = "tabp_LogServicioWMSOleada";
            this.tabp_LogServicioWMSOleada.Size = new System.Drawing.Size(595, 192);
            this.tabp_LogServicioWMSOleada.TabIndex = 4;
            this.tabp_LogServicioWMSOleada.Text = "Log Servicio WMS Oleada";
            this.tabp_LogServicioWMSOleada.UseVisualStyleBackColor = true;
            // 
            // grdv_LogServicioWMSOleada
            // 
            this.grdv_LogServicioWMSOleada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdv_LogServicioWMSOleada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdv_LogServicioWMSOleada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdv_LogServicioWMSOleada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdv_LogServicioWMSOleada.Location = new System.Drawing.Point(0, 0);
            this.grdv_LogServicioWMSOleada.Name = "grdv_LogServicioWMSOleada";
            this.grdv_LogServicioWMSOleada.Size = new System.Drawing.Size(595, 192);
            this.grdv_LogServicioWMSOleada.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grp_Filtro
            // 
            this.grp_Filtro.Controls.Add(this.button1);
            this.grp_Filtro.Controls.Add(this.rdo_Ultimos1000Errores);
            this.grp_Filtro.Controls.Add(this.rdo_ErroresUltimas24Hrs);
            this.grp_Filtro.Controls.Add(this.btn_Buscar);
            this.grp_Filtro.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Filtro.Location = new System.Drawing.Point(0, 233);
            this.grp_Filtro.Name = "grp_Filtro";
            this.grp_Filtro.Size = new System.Drawing.Size(609, 53);
            this.grp_Filtro.TabIndex = 3;
            this.grp_Filtro.TabStop = false;
            this.grp_Filtro.Text = "Opciones de filtro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "guardar soporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rdo_Ultimos1000Errores
            // 
            this.rdo_Ultimos1000Errores.AutoSize = true;
            this.rdo_Ultimos1000Errores.Location = new System.Drawing.Point(200, 25);
            this.rdo_Ultimos1000Errores.Name = "rdo_Ultimos1000Errores";
            this.rdo_Ultimos1000Errores.Size = new System.Drawing.Size(122, 17);
            this.rdo_Ultimos1000Errores.TabIndex = 4;
            this.rdo_Ultimos1000Errores.TabStop = true;
            this.rdo_Ultimos1000Errores.Text = "Utimos 1000 errores.";
            this.rdo_Ultimos1000Errores.UseVisualStyleBackColor = true;
            // 
            // rdo_ErroresUltimas24Hrs
            // 
            this.rdo_ErroresUltimas24Hrs.AutoSize = true;
            this.rdo_ErroresUltimas24Hrs.Location = new System.Drawing.Point(19, 25);
            this.rdo_ErroresUltimas24Hrs.Name = "rdo_ErroresUltimas24Hrs";
            this.rdo_ErroresUltimas24Hrs.Size = new System.Drawing.Size(142, 17);
            this.rdo_ErroresUltimas24Hrs.TabIndex = 3;
            this.rdo_ErroresUltimas24Hrs.TabStop = true;
            this.rdo_ErroresUltimas24Hrs.Text = "Errores (Ultimas 24HRS.)";
            this.rdo_ErroresUltimas24Hrs.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(351, 22);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 536);
            this.Controls.Add(this.grp_Filtro);
            this.Controls.Add(this.grp_TablasLog);
            this.Controls.Add(this.grp_Servicios);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grp_Servicios.ResumeLayout(false);
            this.tbl_Servicios.ResumeLayout(false);
            this.tbl_Servicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioReplica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioWMSSAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioServInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EstadoServicioWMSOleada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.grp_TablasLog.ResumeLayout(false);
            this.tab_TablasLog.ResumeLayout(false);
            this.tabp_LogServicoEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioEmail)).EndInit();
            this.tabp_LogServicioReplicaCD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioReplicaCD)).EndInit();
            this.tabp_LogServicioWMSSAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioWMSSAP)).EndInit();
            this.tabp_LogServicioServInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioServInfo)).EndInit();
            this.tabp_LogServicioWMSOleada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdv_LogServicioWMSOleada)).EndInit();
            this.grp_Filtro.ResumeLayout(false);
            this.grp_Filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_Servicios;
        private System.Windows.Forms.GroupBox grp_TablasLog;
        private System.Windows.Forms.TabControl tab_TablasLog;
        private System.Windows.Forms.TableLayoutPanel tbl_Servicios;
        private System.Windows.Forms.Label lbl_ServicioEmail;
        private System.Windows.Forms.Label lbl_ServicioReplicaCD;
        private System.Windows.Forms.Label lbl_ServicioWMSSAP;
        private System.Windows.Forms.Label lbl_ServicioInfo;
        private System.Windows.Forms.Label lbl_ServicioWMSOleada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_ServidorWMSReplica;
        private System.Windows.Forms.Label lbl_ServidorWMSWMSSAP;
        private System.Windows.Forms.Label lbl_ServidorIntegracionesServInfo;
        private System.Windows.Forms.Label lbl_ServidorPickingWMSOleada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pic_EstadoServicioEmail;
        private System.Windows.Forms.PictureBox pic_EstadoServicioReplica;
        private System.Windows.Forms.PictureBox pic_EstadoServicioWMSSAP;
        private System.Windows.Forms.PictureBox pic_EstadoServicioServInfo;
        private System.Windows.Forms.PictureBox pic_EstadoServicioWMSOleada;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_ServidorWMSEmail;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TabPage tabp_LogServicoEmail;
        private System.Windows.Forms.DataGridView grdv_LogServicioEmail;
        private System.Windows.Forms.GroupBox grp_Filtro;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.RadioButton rdo_Ultimos1000Errores;
        private System.Windows.Forms.RadioButton rdo_ErroresUltimas24Hrs;
        private System.Windows.Forms.TabPage tabp_LogServicioReplicaCD;
        private System.Windows.Forms.TabPage tabp_LogServicioWMSSAP;
        private System.Windows.Forms.TabPage tabp_LogServicioServInfo;
        private System.Windows.Forms.DataGridView grdv_LogServicioReplicaCD;
        private System.Windows.Forms.DataGridView grdv_LogServicioServInfo;
        private System.Windows.Forms.TabPage tabp_LogServicioWMSOleada;
        private System.Windows.Forms.DataGridView grdv_LogServicioWMSOleada;
        private System.Windows.Forms.DataGridView grdv_LogServicioWMSSAP;
        private System.Windows.Forms.Button button1;
    }
}

