using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWorks.UI.BarTender
{
    public static class ControlExtensions
    {
        public static T Clone<T>(this T source) where T : Control
        {

            var target = Activator.CreateInstance(source.GetType());

            foreach (PropertyInfo sourceProperty in source.GetType().GetProperties())
            {
                object newValue = sourceProperty.GetValue(source, null);

                MethodInfo mi = sourceProperty.GetSetMethod(true);
                if (mi != null)
                {
                    sourceProperty.SetValue(target, newValue, null);
                }
            }

            return target as T;
        }
    }
}
