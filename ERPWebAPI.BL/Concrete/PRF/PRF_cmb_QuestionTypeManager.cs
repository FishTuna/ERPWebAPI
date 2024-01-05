

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.PRF;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.PRF;
using ERPWebAPI.EL.Concrete;
using ERPWebAPI.EL.Concrete.PRF;

namespace ERPWebAPI.BL.Concrete.PRF
{
    public class PRF_cmb_QuestionTypeManager : IPRF_cmb_QuestionTypeService<PRF_cmb_QuestionType, SqlResult>
    {
        private readonly IPRF_cmb_QuestionTypeDal _pRF_cmb_QuestionTypeDal;

        public PRF_cmb_QuestionTypeManager(IPRF_cmb_QuestionTypeDal pRF_cmb_QuestionTypeDal)
        {
            _pRF_cmb_QuestionTypeDal = pRF_cmb_QuestionTypeDal;
        }

        //[CacheAspect]
        //[ValidationAspect(typeof(CollarValidator))]
        //[PerformanceAspect(15)]
        public IDataResult<List<PRF_cmb_QuestionType>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<PRF_cmb_QuestionType>>(_pRF_cmb_QuestionTypeDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _pRF_cmb_QuestionTypeDal.ResultOperationsDal(module, target, point, parameters);
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
