using EmployeeAPI.Model;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.InputTypes
{
    public class EmployeeInputType:InputObjectGraphType<Employee>
    {
        public EmployeeInputType()
        {
            Field(a => a.FirstName);
            Field(a =>a.LastName);
            Field(a => a.Email);
        }

    }
}
