using System.Text;

public static class JsonSerializer
{
    public static string Serialize(object obj)
    {
        var type = obj.GetType();
        var properties = type.GetProperties();
        var jsonBuilder = new StringBuilder();

        jsonBuilder.AppendLine("{");

        var i = 0;
        foreach (var property in properties)
        {
            var value = property.GetValue(obj);
            jsonBuilder.Append($"\"{property.Name}\": \"{value}\"");

            if (i < properties.Length - 1)
                jsonBuilder.AppendLine(",");

            i++;
        }

        jsonBuilder.AppendLine();
        jsonBuilder.AppendLine("}");
        return jsonBuilder.ToString();
    }
}
