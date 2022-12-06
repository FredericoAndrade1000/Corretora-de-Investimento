using System.Reflection;
using System.Windows.Forms;
using System;

public static class ControlExtensions
{
    public static T Clone<T>(this T controlToClone)
    {
        PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        T instance = Activator.CreateInstance<T>();

        foreach (PropertyInfo propInfo in controlProperties)
        {
            if (propInfo.CanWrite)
            {
                if (propInfo.Name != "WindowTarget")
                    propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
            }
        }
        return instance;
    }
}