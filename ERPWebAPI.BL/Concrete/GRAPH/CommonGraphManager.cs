using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.GRAPH;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.GRAPH;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.GRAPHS;


namespace ERPWebAPI.BL.Concrete.GRAPH
{
    public class CommonGraphManager : ICommonGraphService<CommonGraph, SqlResult>
    {
        private readonly ICommonGraphDal _CommonGraph;

        public CommonGraphManager(ICommonGraphDal CommonGraph)
        {
            _CommonGraph = CommonGraph;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<CommonGraph>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<CommonGraph>>(_CommonGraph.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _CommonGraph.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }

    }
}
