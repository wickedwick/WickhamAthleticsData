using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickhamAthleticsData.Model;

namespace WickhamAthleticsData.DataAccess.Layout
{
    public static class RowDataAccess
    {
        public static async Task<bool> CreateRow(int renderOrder, string rowClassName, int PageId)
        {
            bool retVal = false;

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    PageRow row = new PageRow
                    {
                        intRenderOrder = renderOrder,
                        strRowClassName = string.IsNullOrEmpty(rowClassName) ? null : rowClassName,
                        FK_intPageId = PageId
                    };
                    ctx.PageRow.Add(row);
                    await ctx.SaveChangesAsync();
                    retVal = true;
                }
            }
            catch (Exception ex)
            {

            }

            return retVal;
        }

        public static async Task<PageRow> GetRowById(int id)
        {
            PageRow row = null;

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    row = await ctx.PageRow.FindAsync(id);
                }
            }
            catch (Exception ex)
            {

            }

            return row;
        }

        public static async Task<List<PageRow>> GetAllRows()
        {
            List<PageRow> rows = new List<PageRow>();

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    rows = ctx.PageRow.Include("WickPage").ToList();
                }
            }
            catch (Exception ex)
            {

            }

            return rows;
        }

        public static async Task<List<PageRow>> GetRowsByPage(int id)
        {
            List<PageRow> rows = new List<PageRow>();

            try
            {
                using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
                {
                    rows = ctx.PageRow.Include("WickPage").Where(r => r.FK_intPageId == id).OrderBy(r => r.intRenderOrder).ToList();
                }
            }
            catch (Exception ex)
            {


            }

            return rows;
        }
    }
}
