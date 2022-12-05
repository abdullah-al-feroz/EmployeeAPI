using EmployeeAPI.Model;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.Type
{
    public class EmployeeType: ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(a => a.FirstName);
            Field(a => a.LastName);
            Field(a => a.Email);

            Field(a => a.department, true, typeof(DepartmentType))
           .Resolve(a => a.Source.department);
        }
    }
}
