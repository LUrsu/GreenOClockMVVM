using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using NexRepository;

namespace GreenOClock.Model
{
    public class TagRepository : Repository<GreenOClockEntities, Tag>, ITagRepository
    {
        public TagRepository(GreenOClockEntities context) : base(context)
        {
        }

        public void RemoveTag(Tag tag)
        {
            //if (tag.EntityKey == null || tag.EntityState == EntityState.Detached)
            //{
            //    DataContext.Tags.Attach(tag);
            //    DataContext.DeleteObject(tag);
            //}
            //else
            //{
            //    DataContext.DeleteObject(tag);
            //}
        }

        public void AddTag(Tag tag)
        {
            Save(tag);
        }
    }
}
