using GraphQL.DataLoader;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.Type
{
    public class EmployeeSkillsType:ObjectGraphType<EmployeeSkill>
    {
        public EmployeeSkillsType()
        {
            Field(a => a.Name);
        }
    }
}
