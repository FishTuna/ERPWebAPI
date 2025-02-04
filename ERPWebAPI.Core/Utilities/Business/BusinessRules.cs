using ERPWebAPI.Core.Utilities.Results;

namespace ERPWebAPI.Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.IsSuccess)
                {
                    return logic;
                }
            }

            return null;
        }
    }
}
