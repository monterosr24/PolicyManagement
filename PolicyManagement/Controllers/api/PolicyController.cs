﻿using PolicyManagement.Controllers.Api;
using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;

namespace PolicyManagement.Controllers.api
{
    public class PolicyController : BaseApiController<Policy, PolicyViewModel, IPolicyService>
    {
    }
}