using System.ComponentModel;
using System.Reflection;

namespace C3i.Azure.AppConfiguration.Util;

public static class EnumExt
{
    public static string LerDescricao(this Enum value)
    {
        FieldInfo field = value.GetType().GetField(value.ToString());
        DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
        return attribute == null ? value.ToString() : attribute.Description;
    }
}