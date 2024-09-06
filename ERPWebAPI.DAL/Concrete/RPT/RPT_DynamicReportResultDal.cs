
using Core.Utilities.Results;
using ERPWebAPI.DAL.Abstract.RPT;
using ERPWebAPI.EL.Concrete.RPT;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Dynamic;

namespace ERPWebAPI.DAL.Concrete.RPT
{
    public class RPT_DynamicReportResultDal : IRPT_DynamicReportResultDal
    {
        //public IDataResult<List<RPT_DynamicReportResult>> GetDynamicReportResultDal(string procedure, string procedureParams)
        //{
        //    List<RPT_DynamicReportResult> results = new List<RPT_DynamicReportResult>();
        //    try
        //    {

        //        using (ErpContext context = new ErpContext())
        //        {

        //            var command = context.Database.GetDbConnection().CreateCommand();
        //            command.CommandText = $"{procedure} {procedureParams}";
        //            command.CommandType = CommandType.Text;

        //            context.Database.OpenConnection();
        //            using (var reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var columns = new Dictionary<string, object>();

        //                    for (int i = 0; i < reader.FieldCount; i++)
        //                    {
        //                        var columnName = reader.GetName(i);
        //                        var columnValue = reader.GetValue(i);

        //                        columns.Add(columnName, columnValue);
        //                    }

        //                    // DynamicClass sınıfını kullanarak sonuçları işle
        //                    var result = new RPT_DynamicReportResult(columns);
        //                    results.Add(result);
        //                }
        //            }
        //        }
        //        return new SuccessDataResult<List<RPT_DynamicReportResult>>(results);
        //    }
        //    catch (Exception)
        //    {
        //        return new ErrorDataResult<List<RPT_DynamicReportResult>>(results);
        //    }
        //}

        public IDataResult<List<ExpandoObject>> GetExpandoReportResultDal(string procedure, string procedureParams)
        {
            List<ExpandoObject> results = new List<ExpandoObject>();
            try
            {
                using (ErpContext context = new ErpContext())
                {

                    var command = context.Database.GetDbConnection().CreateCommand();
                    command.CommandText = $"{procedure} {procedureParams}";
                    command.CommandType = CommandType.Text;

                    context.Database.OpenConnection();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dynamic dynamicResult = new ExpandoObject();
                            var expandoDict = dynamicResult as IDictionary<string, object>;

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                var columnName = reader.GetName(i);
                                var columnValue = reader.GetValue(i);

                                expandoDict[columnName] = columnValue;
                            }

                          
                            results.Add(dynamicResult);
                        }
                    }
                }
                return new SuccessDataResult<List<ExpandoObject>>(results);
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<ExpandoObject>>(results);
            }
        }

    }
}
