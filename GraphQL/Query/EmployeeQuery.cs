using EmployeeAPI.GenericRepo;
using EmployeeAPI.GraphQL.Type;
using EmployeeAPI.Model;
using GraphQL;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.Query
{
    public class EmployeeQuery : ObjectGraphType
    {
        private readonly IGenericRepo<Employee> _employee;

        public EmployeeQuery(IGenericRepo<Employee> employee)
        {
          _employee = employee;

        Field<ListGraphType<EmployeeType>>("AllEmployee", "Get all Employees",
        resolve: context => _employee.GetAll()
        );

        Field<EmployeeType>(
            "Employee", "Get employee by given id",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>
            {
                Name = "id",
                Description = "The id of the employee"
            }),
            resolve: context =>
            {
                var id = context.GetArgument<int>("id");
                return _employee.GetById(id);
            });
        } 
    }
}
