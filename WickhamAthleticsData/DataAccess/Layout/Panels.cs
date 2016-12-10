using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickhamAthleticsData.Model;

namespace WickhamAthleticsData.DataAccess.Layout
{
    public class Panels
    {
        public static Panel GetPanelById(int id)
        {
            Panel panel = null;

            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    panel = ctx.Panel.Where(p => p.PK_PanelID == id).FirstOrDefault();
                }
                catch (Exception ex)
                {

                }
            }

            return panel;
        }
    }
}
