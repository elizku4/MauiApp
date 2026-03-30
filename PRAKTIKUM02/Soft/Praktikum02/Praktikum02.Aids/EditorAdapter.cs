using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02.Aids
{
    public class EditorAdapter
    {
        private readonly object item;

        public EditorAdapter(object item)
        {
            this.item = item;
        }

        public IEnumerable<IPropertyAdapter> Properties
        {
            get
            {
                return item
                    .GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Select(p => new PropertyAdapter(item, p.Name));
            }
        }
    }
}
