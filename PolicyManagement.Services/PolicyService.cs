using System;
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
            ValidatePolicy(toInsert);
            return base.Create(toInsert, user);
        }

        public override PolicyViewModel Update(int id, PolicyViewModel toUpdate, string user)
        {
            ValidatePolicy(toUpdate);
            return base.Update(id, toUpdate, user);
        }

        private void ValidatePolicy(PolicyViewModel policy)
        {
            var typeCovering = _repository.GetId<TypeCovering>(policy.IdTypeCovering);
            var typeRisk = _repository.GetId<TypeRisk>(policy.IdTypeRisk);

            if (typeRisk.Type == Constants.TypeRiskNames.hight && typeCovering.Percentage > 50)
            {
                throw new Exception("La poliza no cumple con la regla de negocio, no puede ser de riesgo alto con un porcentaje mayor al 50% ");
            }
        }
    }
}
