using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ctepl.Anand.DTO;

namespace Ctepl.Anand
{
    public class EnhancementsOnTheUIUXDesignsRepository
    {
        public void CreateEnhancementsOnTheUIUXDesigns(EnhancementsOnTheUIUXDesigns entity)
        {
            using (var context = new DBEntities())
            {
                context.EnhancementsOnTheUIUXDesigns.Add(entity);
                context.SaveChanges();
            }
        }

        public void UpdateEnhancementsOnTheUIUXDesigns(EnhancementsOnTheUIUXDesigns entity)
        {
            using (var context = new DBEntities())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public EnhancementsOnTheUIUXDesigns GetEnhancementsOnTheUIUXDesignsById(int id)
        {
            using (var context = new DBEntities())
            {
                return context.EnhancementsOnTheUIUXDesigns.Find(id);
            }
        }

        public void DeleteEnhancementsOnTheUIUXDesigns(int id)
        {
            using (var context = new DBEntities())
            {
                var entity = GetEnhancementsOnTheUIUXDesignsById(id);
                context.EnhancementsOnTheUIUXDesigns.Remove(entity);
                context.SaveChanges();
            }
        }
    }
}