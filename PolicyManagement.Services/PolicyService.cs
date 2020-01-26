using System;
using System.Collections.Generic;
using System.Data.Entity;
using PolicyManagement.Common;
using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;

namespace PolicyManagement.Services
{
    public class PolicyService : BaseService<Policy, PolicyViewModel>, IPolicyService
    {
        public PolicyService(DbContext context) : base(context)
        {
        }

        public override PolicyViewModel Create(PolicyViewModel toInsert, string user)
        {
            var typeCovering = _repository.GetId<TypeCovering>(toInsert.IdTypeCovering);
            var typeRisk = _repository.GetId<TypeRisk>(toInsert.IdTypeRisk);

            if (typeRisk.Type == Constants.TypeRiskNames.hight && typeCovering.Percentage > 50)
            {
                return null;
                //throw new Exception("errot ");
            }

            return base.Create(toInsert, user);
        }
    }
}
