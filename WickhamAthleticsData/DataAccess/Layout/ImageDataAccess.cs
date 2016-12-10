using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickhamAthleticsData.Model;

namespace WickhamAthleticsData.DataAccess.Layout
{
    public class ImageDataAccess
    {
        public static Image GetImageById(int id)
        {
            Image image = null;

            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    image = ctx.Image.Where(i => i.PK_ImageID == id).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    //
                }
            }

            return image;
        }
        
        public static Image GetImageByPanelId(int id)
        {
            Image image = null;

            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    image = ctx.Image.Where(i => i.FK_Panel == id).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    //
                }
            }

            return image;
        }

        // Add image carousel stuff here.
        public static List<Image> GetImagesByCarouselId(int id)
        {
            List<Image> images = new List<Image>();
            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    images = ctx.Image.Where(i => i.FK_CarouselID == id).ToList();
                }
                catch (Exception ex)
                {
                    //
                }
                finally
                {
                    ctx.Dispose();
                }
            }

            return images;
        }

        public static ImageCarousel GetImageCarouselByPanelId(int id)
        {
            ImageCarousel carousel = null;

            using (WickhamAthleticsEntities ctx = new WickhamAthleticsEntities())
            {
                try
                {
                    carousel = ctx.ImageCarousel.Include("Image")
                                                .Where(i => i.FK_Panel == id).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    //
                }
            }

            return carousel;
        }
    }
}
