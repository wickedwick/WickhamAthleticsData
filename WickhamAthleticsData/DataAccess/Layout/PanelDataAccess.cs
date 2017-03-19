using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickhamAthleticsData.Model;

namespace WickhamAthleticsData.DataAccess.Layout
{
    public static class PanelDataAccess
    {
        public static async Task<bool> CreatePanel(int rowId, int renderOrder, int width, string className)
        {
            bool retVal = false;

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    RowPanel panel = new RowPanel
                    {
                        FK_intRowId = rowId,
                        intRenderOrder = renderOrder,
                        intWidth = width,
                        strPanelClassName = className
                    };
                    ctx.RowPanel.Add(panel);
                    await ctx.SaveChangesAsync();
                    retVal = true;
                }
            }
            catch (Exception ex)
            {
                retVal = false;
            }

            return retVal;
        }

        public static async Task<RowPanel> GetPanelById(int id)
        {
            RowPanel panel = null;

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    panel = await ctx.RowPanel.FindAsync(id);
                }
            }
            catch (Exception ex)
            {
                // Return default error panel here.
            }

            return panel;
        }

        public static async Task<List<RowPanel>> GetAllPanels()
        {
            List<RowPanel> panels = new List<RowPanel>();

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    panels = ctx.RowPanel.ToList();
                }
            }
            catch (Exception ex)
            {

            }

            return panels;
        }

        public static async Task<List<RowPanel>> GetPanelsByRow(int id)
        {
            List<RowPanel> panels = new List<RowPanel>();

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    panels = ctx.RowPanel.Where(p => p.FK_intRowId == id).ToList();
                }
            }
            catch (Exception ex)
            {

            }

            return panels;
        }
    }
}
