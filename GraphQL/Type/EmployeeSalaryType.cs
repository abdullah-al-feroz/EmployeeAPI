using EmployeeAPI.Model;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.Type
{
    public class EmployeeSalaryType: ObjectGraphType<EmployeeSalary>
    {
        public EmployeeSalaryType()
        {
            Field(a => a.Salary);
        }
    }
}
