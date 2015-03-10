using System.Collections.Generic;
using System.Linq;

namespace GreenOClock.Model
{
    internal interface ITagRepository
    {
        void RemoveTag(Tag tag);
        void AddTag(Tag tag);
    }
}