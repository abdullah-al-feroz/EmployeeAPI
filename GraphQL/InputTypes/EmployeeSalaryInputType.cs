using EmployeeAPI.Model;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.InputTypes
{
    public class EmployeeSalaryInputType: InputObjectGraphType<EmployeeSalary>
    {
        public EmployeeSalaryInputType()
        {
            Field(a => a.Salary);
        }
    }
}
