using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public interface IDestinationCollection : IEnumerable<IDestinationEntity>
    {
        string Name { get; set; }

        int Count();
    }


    public interface IDestinationEntity
    {
        string Name { get; set; }
        string Value { get; set; }
    }

    public class DestinationCollection : IDestinationCollection
    {
        public string Name { get; set; }

        public int Count()
        {
            return 0;
        }

        public IEnumerator<IDestinationEntity> GetEnumerator()
        {
            return (IEnumerator<IDestinationEntity>)this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }

    public interface IDestinationSurvey
    {
        IDestinationCollection Collection { get; set; }
    }

    public class DestinationSurvey : IDestinationSurvey
    {
        public IDestinationCollection Collection { get; set; }
    }
}
