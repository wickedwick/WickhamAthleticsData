using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickhamAthleticsData.Model;

namespace WickhamAthleticsData.DataAccess.Layout
{
    public static class PageDataAccess
    {
        public static async Task<bool> CreatePage(string name, string path)
        {
            bool retVal = false;

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    WickPage page = new WickPage
                    {
                        strPageName = string.IsNullOrEmpty(name) ? null : name,
                        strPagePath = string.IsNullOrEmpty(path) ? null : path
                    };
                    ctx.WickPage.Add(page);
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

        public static async Task<WickPage> GetPageById(int id)
        {
            WickPage page = null;
            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    page = await ctx.WickPage.FindAsync(id);
                }
            }
            catch (Exception ex)
            {
                // Should return error page and display error here
            }

            return page;
        }

        public static async Task<WickPage> GetPageByName(string name)
        {
            WickPage page = null;

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    page = ctx.WickPage.Include("PageRow").Include("PageRow.RowPanel").Where(p => p.strPageName == name).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

            }

            return page;
        }

        public static async Task<List<WickPage>> GetAllPages()
        {
            List<WickPage> pageList = new List<WickPage>();

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    pageList = ctx.WickPage.Include("PageRow").ToList();
                }
            }
            catch (Exception ex)
            {

            }

            return pageList;
        }
    }
}
