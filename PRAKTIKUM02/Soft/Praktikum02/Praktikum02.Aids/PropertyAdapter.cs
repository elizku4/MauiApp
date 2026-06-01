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
            if (value is null)
            {
                Prop.SetValue(item, null);
                return;
            }

            var text = value.ToString();

            if (string.IsNullOrWhiteSpace(text))
            {
                if (Nullable.GetUnderlyingType(PropType) != null || !PropType.IsValueType)
                {
                    Prop.SetValue(item, null);
                }
                else
                {
                    Prop.SetValue(item, Activator.CreateInstance(PropType));
                }

                return;
            }

            var targetType = UnderlyingType;
            object convertedValue;

            if (targetType == typeof(string))
            {
                convertedValue = text;
            }
            else if (targetType == typeof(Guid))
            {
                convertedValue = Guid.Parse(text);
            }
            else if (targetType == typeof(int))
            {
                convertedValue = int.Parse(text);
            }
            else if (targetType == typeof(double))
            {
                convertedValue = double.Parse(text);
            }
            else if (targetType == typeof(decimal))
            {
                convertedValue = decimal.Parse(text);
            }
            else if (targetType == typeof(DateTime))
            {
                convertedValue = DateTime.Parse(text);
            }
            else if (targetType == typeof(bool))
            {
                convertedValue = bool.Parse(text);
            }
            else
            {
                convertedValue = Convert.ChangeType(text, targetType);
            }

            Prop.SetValue(item, convertedValue);
        }
    }
}
