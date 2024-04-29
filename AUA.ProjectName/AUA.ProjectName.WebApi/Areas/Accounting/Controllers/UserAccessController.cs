﻿using AUA.ProjectName.DomainEntities.Entities.Accounting.UserAccessAggregate;
using AUA.ProjectName.WebApi.Controllers;
using AUA.ProjectName.WebApi.Utility.ApiAuthorization;

namespace AUA.ProjectName.WebApi.Areas.Accounting.Controllers
{
    [WebApiAuthorize(EUserAccess.UserAccess)]
    public class UserAccessController : BaseApiController
    {



    }
}