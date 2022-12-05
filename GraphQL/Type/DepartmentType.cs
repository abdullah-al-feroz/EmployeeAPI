using EmployeeAPI.Model;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.Type
{
    public class DepartmentType:ObjectGraphType<Department>
    {
        public DepartmentType()
        {
            Field(a => a.Id, nullable:true);
            Field(a => a.Name);
            Field(a => a.Phone);
            Field(a => a.EmployeeId);   
        }
    }
}
