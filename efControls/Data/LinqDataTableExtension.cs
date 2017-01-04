using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Reflection;

namespace efControls
{
    public static class LinqDataTableExtension
    {
        public static void ResetTableCache(this ITable table)
        {
            table.InternalSetNonPublicFieldValue("cachedList", null);
        }

        public static void ResetTableCache(this IListSource source)
        {
            source.InternalSetNonPublicFieldValue("cachedList", null);
        }

        public static void InternalSetNonPublicFieldValue(this object entity, string propertyName, object value)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            if (string.IsNullOrEmpty(propertyName))
                throw new ArgumentNullException("propertyName");

            var type = entity.GetType();
            var prop = type.GetField(propertyName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (prop != null)
                prop.SetValue(entity, value);
            // add any exception code here if property was not found :)
        }
    }
}
