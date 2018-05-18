using System;
using System.Windows.Forms;
using System.ServiceProcess;
using Capa_Datos;
using System.Data.SqlClient;
using System.Data;
using Capa_Entidades;
namespace monitor_Alpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            servEmails();
            servRepDC();
            servWMSSAP();
            servInfo();
            servWMSOlea();
            cargaTablaError();
            cargaTablaError_ServicioMail();
            cargaTablaError_ServicioReplicaCD();
            grdv_LogServicioWMSSAP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ActiveControl = grdv_LogServicioWMSSAP;
        }
        // servEmails() controla el estado de Servicio_Emails, ademas activarlo en caso de no estarlo  
        public void servEmails()

        {
            ServiceController se = new ServiceController("Servicio_WMS_SAP", "101.1.1.14");

            if (se != null && se.Status == ServiceControllerStatus.Running)
            {
                pic_EstadoServicioEmail.Image = monitor_Alpha.Properties.Resources.checkv;

            }
            else
            {
                pic_EstadoServicioEmail.Image = monitor_Alpha.Properties.Resources.Cruz_roja;
                se.Start();
                se.WaitForStatus(ServiceControllerStatus.Running);
            }


        }
        // servRepDC() controla el estado de Servicio_Replica_CD, ademas activarlo en caso de no estarlo  
        private void servRepDC()
        {
            ServiceController sr = new ServiceController("SamSs");

            if (sr != null && sr.Status == ServiceControllerStatus.Running)
            {
                pic_EstadoServicioReplica.Image = monitor_Alpha.Properties.Resources.checkv;
            }
            else
            {
                pic_EstadoServicioReplica.Image = monitor_Alpha.Properties.Resources.Cruz_roja;
                sr.Start();
            }
        }
        // servWMSSAP() controla el estado de Servicio WMS SAP, ademas activarlo en caso de no estarlo  
        private void servWMSSAP()
        {
            ServiceController sws = new ServiceController("KeyIso");

            if (sws != null && sws.Status == ServiceControllerStatus.Running)
            {
                pic_EstadoServicioWMSSAP.Image = monitor_Alpha.Properties.Resources.checkv;
            }
            else
            {
                pic_EstadoServicioWMSSAP.Image = monitor_Alpha.Properties.Resources.Cruz_roja;
                sws.Start();

            }
        }
        // servInfo() controla el estado de Servicio ServInfo, ademas activarlo en caso de no estarlo  
        private void servInfo()
        {
            ServiceController si = new ServiceController("Dhcp");

            if (si != null && si.Status == ServiceControllerStatus.Running)
            {
                pic_EstadoServicioServInfo.Image = monitor_Alpha.Properties.Resources.checkv;
            }
            else
            {
                pic_EstadoServicioServInfo.Image = monitor_Alpha.Properties.Resources.Cruz_roja;
                si.Start();
            }
        }
        // servWMSOlea() controla el estado de WMS_Oleada, ademas activarlo en caso de no estarlo  
        private void servWMSOlea()
        {
            ServiceController swo = new ServiceController("NetMan");

            if (swo != null && swo.Status == ServiceControllerStatus.Running)
            {
                pic_EstadoServicioWMSOleada.Image = monitor_Alpha.Properties.Resources.checkv;
            }
            else
            {
                pic_EstadoServicioWMSOleada.Image = monitor_Alpha.Properties.Resources.Cruz_roja;
                swo.Start();
            }
        }
        // timer se encarga de ir ejecutando los metodos que mantienen los servicios cada 5 seg
        // para mantener actualizado su estado
        private void timer1_Tick(object sender, EventArgs e)
        {
            servEmails();
            servRepDC();
            servWMSSAP();
            servInfo();
            servWMSOlea();
            
        }

        // carga una vista previa de los datos de errores en la datagridview de la tabpage selecicionada
        private void cargaTablaError()
        {
            grdv_LogServicioWMSSAP.DataSource = ClaseLogServicioWMSSAP.CargaLogError();
            grdv_LogServicioWMSSAP.Refresh();
            grdv_LogServicioWMSSAP.Update();
        }

        private void cargaTablaError_ServicioMail()
        {
            grdv_LogServicioEmail.DataSource = ClaseLogServicioMail.CargaLogError_ServicoMail();
            grdv_LogServicioEmail.Refresh();
            grdv_LogServicioEmail.Update();
        }
        private void cargaTablaError_ServicioReplicaCD()
        {
            grdv_LogServicioReplicaCD.DataSource = ClaseLogServicioReplicaCD.CargaLogError_ServicoReplicaCD();
            grdv_LogServicioReplicaCD.Refresh();
            grdv_LogServicioReplicaCD.Update();
        }
        //no hace nada
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // boton buscar para ejecutar el filtro deseado u seleccionado
        private void button1_Click(object sender, EventArgs e)
        {
            //Consulta cual tabPage esta selecionada para aplicarle el filtro seleccionado
            if (tab_TablasLog.SelectedTab == tabp_LogServicoEmail)
            {
                //verifica cual de las 2 opciones de friltro esta selecionada y al precionar el boton buscar carga el stored procedure correspondiente
                if (rdo_ErroresUltimas24Hrs.Checked == true)
                {
                    grdv_LogServicioEmail.DataSource = ClaseLogServicioMail.Carga24hrs_ServicioMail();
                    grdv_LogServicioEmail.Refresh();
                }
                else if (rdo_Ultimos1000Errores.Checked == true)
                {
                    grdv_LogServicioEmail.DataSource = ClaseLogServicioMail.Carga1000_ServicioMail();
                    grdv_LogServicioEmail.Refresh();
                }
            }
            else if (tab_TablasLog.SelectedTab == tabp_LogServicioReplicaCD)
            {
                if (rdo_ErroresUltimas24Hrs.Checked == true)
                {
                    grdv_LogServicioReplicaCD.DataSource = ClaseLogServicioReplicaCD.Carga24hrs_ServicioReplicaCD();
                    grdv_LogServicioReplicaCD.Refresh();
                }
                else if (rdo_Ultimos1000Errores.Checked == true)
                {
                    grdv_LogServicioReplicaCD.DataSource = ClaseLogServicioReplicaCD.Carga1000_ServicioReplicaCD();
                    grdv_LogServicioReplicaCD.Refresh();
                }
            }
            else if (tab_TablasLog.SelectedTab == tabp_LogServicioWMSSAP)
            {
                if (rdo_ErroresUltimas24Hrs.Checked == true)
                {
                    grdv_LogServicioWMSSAP.DataSource = ClaseLogServicioWMSSAP.Carga24hrs();
                    grdv_LogServicioWMSSAP.Refresh();
                    grdv_LogServicioWMSSAP.Update();
                }
                else if (rdo_Ultimos1000Errores.Checked == true)
                {
                    grdv_LogServicioWMSSAP.DataSource = ClaseLogServicioWMSSAP.Carga1000();
                    grdv_LogServicioWMSSAP.Refresh();
                    grdv_LogServicioWMSSAP.Update();
                }
            }
            else if (tab_TablasLog.SelectedTab == tabp_LogServicioServInfo)
            {
                if (rdo_ErroresUltimas24Hrs.Checked == true)
                {

                }
                else if (rdo_Ultimos1000Errores.Checked == true)
                {

                }
            }


        }

        public void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        string ID;
        string ObservacionSoporte;
        bool EstadoSoporte = true;
        
        private void grdv_LogServicioWMSSAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = grdv_LogServicioWMSSAP.SelectedRows[0].Cells["ID"].Value.ToString();
            ObservacionSoporte = grdv_LogServicioWMSSAP.SelectedRows[0].Cells["Observacion de soporte"].Value.ToString();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            errorEntity oLog = new errorEntity();
            
            oLog.LogI_id = Convert.ToInt32(ID);
            oLog.LogI_ObservSoporte = ObservacionSoporte;
            oLog.LogI_StatusSoporte = EstadoSoporte;

            grdv_LogServicioWMSSAP.Refresh();
            grdv_LogServicioWMSSAP.Update();

            try
            {
                Capa_Datos.ClaseUpdateServicioWMSSAP.Update_soporte(oLog);
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Monitor servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
        }
        
        
    }

}
