using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.CoachSO
{
    public class DeleteCoachSO : BaseSO
    {
        Coach coach;
        public DeleteCoachSO(Coach coach)
        {
            this.coach = coach;
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Delete(coach, coach.CoachID);
        }
    }
}
