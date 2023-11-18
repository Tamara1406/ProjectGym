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
            repository = new CoachRepository();
        }
        protected override void ExecuteConcreteOperation()
        {
            repository.Delete(coach, coach.CoachID);
        }
    }
}
