using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickhamAthleticsData.Model;
using WickhamAthleticsData.DataAccess.Base;

namespace WickhamAthleticsData.DataAccess.Layout
{
    public class ContentDataAccess
    {
        public static Content GetContentById(int id)
        {
            Content content = null;

            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    content = ctx.Content.Where(c => c.PK_ContentID == id).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    //
                }
            }

            return content;
        }

        public static Content GetContentByName(string name)
        {
            Content content = null;

            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    content = ctx.Content.Where(c => c.Name.ToLower().Equals(name.ToLower())).FirstOrDefault();
                }
                catch (Exception ex)
                {

                }
            }

            return content;
        }
    }
}
