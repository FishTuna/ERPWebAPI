using Core.Entities;
using System.Dynamic;

namespace ERPWebAPI.EL.Concrete.RPT
{
    public class RPT_DynamicReportResult : DynamicObject, IEntity
    {

        //public Dictionary<string, object> Columns { get; } = new Dictionary<string, object>();

        //public RPT_DynamicReportResult(Dictionary<string, object> columns)
        //{
        //    Columns = columns;

        //    // Property'leri otomatik olarak oluştur
        //    foreach (var column in Columns)
        //    {
        //        var propertyName = column.Key;
        //        var propertyValue = column.Value;

        //        // Property'yi oluştur ve değeri at
        //        GetType().GetProperty(propertyName)?.SetValue(this, propertyValue, null);
        //    }
        //}

        private readonly Dictionary<string, object> columnValues = new Dictionary<string, object>();

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            var memberName = binder.Name;
            if (columnValues.ContainsKey(memberName))
            {
                result = columnValues[memberName];
                return true;
            }

            result = null;
            return false;
        }

        public void AddColumnValue(string columnName, object value)
        {
            columnValues[columnName] = value;
        }

    }
}
