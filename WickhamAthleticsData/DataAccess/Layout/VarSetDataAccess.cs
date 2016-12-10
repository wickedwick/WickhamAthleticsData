using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickhamAthleticsData.Model;

namespace WickhamAthleticsData.DataAccess.Layout
{
    public class VarSetDataAccess
    {
        public static VarSet GetVarSetById(int id)
        {
            VarSet vars = null;
            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    vars = ctx.VarSet.Where(v => v.PK_VarSet == id).FirstOrDefault();
                }
                catch (Exception ex)
                {

                }
            }           

            return vars;
        }

        public static List<VarSet> GetVarSetByPanelId(int id)
        {
            List<VarSet> vars = new List<VarSet>();

            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    vars = ctx.VarSet.Where(v => v.FK_Panel == id).ToList();
                }
                catch (Exception ex)
                {
                    //
                }
            }

            return vars;
        }

        public static VarSet GetVarSetByName(string name)
        {
            VarSet vars = null;
            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    vars = ctx.VarSet.Where(v => v.Name == name).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    //
                }
            }

            return vars;
        }
    }
}
