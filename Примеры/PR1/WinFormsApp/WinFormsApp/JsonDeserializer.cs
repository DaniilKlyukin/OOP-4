using System.Text.RegularExpressions;

public static class JsonDeserializer
{
    public static object Deserialize(Type type, string json)
    {
        object? obj = Activator.CreateInstance(type);
        var properties = type.GetProperties();

        json = Regex.Replace(json, "[\r\n]", string.Empty);

        // Удаляем фигурные скобки и разбиваем по запятой
        var pairs = json.Trim('{', '}').Split(',');

        foreach (var pair in pairs)
        {
            var keyValue = pair.Split(':');
            var propertyName = keyValue[0].Trim().Trim('"');
            var propertyValue = keyValue[1].Trim().Trim('"');

            var property = type.GetProperty(propertyName);
            if (property != null)
            {
                // Преобразуем строковое значение в тип свойства
                if (property.PropertyType == typeof(int))
                {
                    property.SetValue(obj, int.Parse(propertyValue));
                }
                else if (property.PropertyType == typeof(double))
                {
                    property.SetValue(obj, double.Parse(propertyValue));
                }
                else if (property.PropertyType == typeof(string))
                {
                    property.SetValue(obj, propertyValue);
                }
            }
        }

        return obj;
    }
}
