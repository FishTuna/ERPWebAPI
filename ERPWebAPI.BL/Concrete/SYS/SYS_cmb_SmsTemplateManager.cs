

using Core.Utilities.Results;
using ERPWebAPI.BL.Abstract.SYS;
using ERPWebAPI.BL.Constants;
using ERPWebAPI.DAL.Abstract.SYS;
using ERPWebAPI.EL.Concrete.SYS;
using ERPWebAPI.EL.Concrete;
using System.Linq.Expressions;

namespace ERPWebAPI.BL.Concrete.SYS
{
    public class SYS_cmb_SmsTemplateManager : ISYS_cmb_SmsTemplateService<SYS_cmb_SmsTemplate, SqlResult>
    {
        private readonly ISYS_cmb_SmsTemplateDal _sys_cmb_SmsTemplateDal;

        public SYS_cmb_SmsTemplateManager(ISYS_cmb_SmsTemplateDal sYS_cmb_SmsTemplateDal)
        {
            _sys_cmb_SmsTemplateDal = sYS_cmb_SmsTemplateDal;
        }

        public SYS_cmb_SmsTemplate Get(Expression<Func<SYS_cmb_SmsTemplate, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SYS_cmb_SmsTemplate>> GetAllDataMngr(string module, string target, string point, string parameters)
        {
            ///kurallar private mwthod olarak eklenecek aşağpıya
            //IDataResult<SqlResult> result = BusinessRules.Run();
            //if (result != null)
            //{
            //    return result;
            //}
            return new SuccessDataResult<List<SYS_cmb_SmsTemplate>>(_sys_cmb_SmsTemplateDal.GetAllDataDal(module, target, point, parameters), Messages.Listed);
        }

        public IDataResult<SqlResult> ResultOperationsMngr(string module, string target, string point, string parameters)
        {
            var result = _sys_cmb_SmsTemplateDal.ResultOperationsDal(module, target, point, parameters);
            if (!result.sqlReturn)
            {
                return new ErrorDataResult<SqlResult>(result);
            }
            return new SuccessDataResult<SqlResult>(result);
        }
    }
}
