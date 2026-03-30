using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02.Aids
{
    public interface IPropertyAdapter
    {
        Type ItemType { get; }
        object Item { get; }

        PropertyInfo PropInfo { get; }
        Type PropType { get; }
        Type UnderlyingType { get; }

        object PropValue { get; }

        void SetValue(object value);
    }

    public class PropertyAdapter : IPropertyAdapter
    {
        private readonly object item;
        private readonly string propertyName;

        public PropertyAdapter(object item, string propertyName)
        {
            this.item = item;
            this.propertyName = propertyName;
        }

        public Type ItemType => item.GetType();

        public object Item => item;

        private PropertyInfo Prop => ItemType.GetProperty(propertyName);

        public PropertyInfo PropInfo => Prop;

        public Type PropType => Prop.PropertyType;

        public Type UnderlyingType =>
            Nullable.GetUnderlyingType(PropType) ?? PropType;

        public object PropValue => Prop.GetValue(item);

        public void SetValue(object value)
        {
            Prop.SetValue(item, value);
        }
    }
}
