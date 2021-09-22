using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab
{
    public interface ISourceCollection : IEnumerable<ISourceEntity>
    {
        string Name { get; set; }

        int Count();
    }


    public interface ISourceEntity
    {
        string Name { get; set; }
        string Value { get; set; }
    }

    public class SourceCollection : ISourceCollection
    {
        public string Name { get; set; }

        public int Count()
        {
            return 0;
        }

        public IEnumerator<ISourceEntity> GetEnumerator()
        {
            return (IEnumerator<ISourceEntity>)this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
