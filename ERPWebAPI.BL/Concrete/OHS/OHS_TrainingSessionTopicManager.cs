

using ERPWebAPI.BL.Abstract.OHS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.Core.Utilities.Results;
using ERPWebAPI.DAL.Abstract.OHS;
using ERPWebAPI.EL.Concrete.OHS;
using ERPWebAPI.EL.Concrete;

namespace ERPWebAPI.BL.Concrete.OHS
{
    public class OHS_TrainingSessionTopicManager : IOHS_TrainingSessionTopicService<OHS_TrainingSessionTopic, SqlResult>
    {
        IOHS_TrainingSessionTopicDal _oHS_TrainingSessionTopicDal;

        public OHS_TrainingSessionTopicManager(IOHS_TrainingSessionTopicDal oHS_TrainingSessionTopicDal)
        {
            _oHS_TrainingSessionTopicDal = oHS_TrainingSessionTopicDal;
        }


        //[CacheAspect]
        //[ValidationAspect(typeof(VacationTypeValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<OHS_TrainingSessionTopic>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<OHS_TrainingSessionTopic>>(_oHS_TrainingSessionTopicDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _oHS_TrainingSessionTopicDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
