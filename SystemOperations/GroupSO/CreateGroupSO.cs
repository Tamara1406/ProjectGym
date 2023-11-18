using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GroupSO
{
    public class CreateGroupSO : BaseSO
    {
        Group group;
        public CreateGroupSO(Group group)
        {
            repository = new GroupRepository();
            this.group = group;
        }
        protected override void ExecuteConcreteOperation()
        {
            repository.Create(group);
        }
    }
}
