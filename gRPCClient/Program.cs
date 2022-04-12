// We create a channel that represents the connection from client to the server
// The URL that we add is provided from Kestrel in the server
using Grpc.Net.Client;
using GrpcService;

var channel = GrpcChannel.ForAddress("http://localhost:5115");

// this the strongly typed client that was create for us from code generation
// when we added the .proto file

var customerClient = new Customer.CustomerClient(channel);

var result = await customerClient.GetCustomerInfoAsync(new CustomerFindModel()
{
    UserId = 1
});

Console.WriteLine($"First Name: {result.FirstName} - Last Name: {result.LastName}");

var result2 = await customerClient.GetCustomersInfoAsync(new EmptyModel { });

if(result2 != null)
    foreach (var item in result2.Items)
    {
        Console.WriteLine($"First Name: {item.FirstName} - Last Name: {item.LastName}");
    }



Console.WriteLine($"First Name: {result.FirstName} - Last Name: {result.LastName}");