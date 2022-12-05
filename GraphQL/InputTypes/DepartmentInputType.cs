using EmployeeAPI.Model;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.InputTypes
{
    public class DepartmentInputType: InputObjectGraphType<Department>
    {
        public DepartmentInputType()
        {
            Field(a => a.Id, nullable: true);
            Field(a => a.Name);
            Field(a => a.Phone);
            Field(a => a.EmployeeId);
        }
    }
}
