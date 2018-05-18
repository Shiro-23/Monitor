using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace Capa_Entidades
{
    public  class errorEntity
    {        
            public  string LogI_ObservSoporte { get ; set ;}
            public  bool LogI_StatusSoporte { get ; set ;} 
            public   int LogI_id { get; set; }
            public  int LogI_Fecha { get; set; }
            public  string LogI_TipoDoc { get; set; }
            public  string LogI_Mensaje { get; set; }
            public  int LogI_IndError { get; set; }

        
    }
}
