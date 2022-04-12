using Grpc.Core;

namespace GrpcService.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        private readonly ILogger<CustomerService> _logger;
        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomersDataModel> GetCustomersInfo(EmptyModel request, ServerCallContext context)
        {
            CustomersDataModel result = new CustomersDataModel();
            result.Items.Add(new CustomerDataModel { FirstName = "FirstName1", LastName = "LastName1" });
            result.Items.Add(new CustomerDataModel { FirstName = "FirstName2", LastName = "LastName2" });
            result.Items.Add(new CustomerDataModel { FirstName = "FirstName3", LastName = "LastName3" });
            result.Items.Add(new CustomerDataModel { FirstName = "FirstName4", LastName = "LastName4" });
            result.Items.Add(new CustomerDataModel { FirstName = "FirstName5", LastName = "LastName5" });
            result.Items.Add(new CustomerDataModel { FirstName = "FirstName6", LastName = "LastName6" });
            return Task.FromResult(result);
        }
        public override Task<CustomerDataModel> GetCustomerInfo(CustomerFindModel request, ServerCallContext context)
        {
            CustomerDataModel result = new CustomerDataModel();

            // This is a sample code for demo
            // in real life scenarios this information should be fetched from the database
            // no data should be hardcoded in the application
            if (request.UserId == 1)
            {
                result.FirstName = "Mohamad";
                result.LastName = "Lawand";
            }
            else if (request.UserId == 2)
            {
                result.FirstName = "Richard";
                result.LastName = "Feynman";
            }
            else if (request.UserId == 3)
            {
                result.FirstName = "Bruce";
                result.LastName = "Wayne";
            }
            else
            {
                result.FirstName = "James";
                result.LastName = "Bond";
            }

            return Task.FromResult(result);
        }
    }
}
