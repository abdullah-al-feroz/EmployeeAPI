using GraphQL.Types;

namespace EmployeeAPI.GraphQL.InputTypes
{
    public class EmployeeSkillsInputType: InputObjectGraphType<EmployeeSkill>
    {
        public EmployeeSkillsInputType()
        {
            Field(a => a.Name);
        }
    }
}
