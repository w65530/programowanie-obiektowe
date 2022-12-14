namespace WebApiProject.Services.Lab5
{
    public class EmployeeListNotFoundException : Exception
    {
        public EmployeeListNotFoundException()
        {
        }
        public EmployeeListNotFoundException(string message)
            : base(message)
        {
        }
        public EmployeeListNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
