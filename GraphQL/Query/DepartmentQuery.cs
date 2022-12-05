﻿using EmployeeAPI.GenericRepo;
using EmployeeAPI.GraphQL.Type;
using EmployeeAPI.Model;
using GraphQL;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.Query
{
    public class DepartmentQuery: ObjectGraphType
    {
        private readonly IGenericRepo<Department> _department;

        public DepartmentQuery(IGenericRepo<Department> department)
        {
            _department = department;
            Field<ListGraphType<DepartmentType>>("AllDepartments", "Get all Departments",
           resolve: context => _department.GetAll()
           );

            Field<DepartmentType>(
                "Department", "Get department by given id",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>
                {
                    Name = "id",
                    Description = "The id of the department"
                }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return _department.GetById(id);
                });
        }
    }
}
