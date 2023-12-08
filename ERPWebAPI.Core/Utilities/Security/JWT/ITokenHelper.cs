﻿using Core.Entities.Concrete;


namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(tbl_Users user, List<OperationClaim> operationClaims);
    }
}
