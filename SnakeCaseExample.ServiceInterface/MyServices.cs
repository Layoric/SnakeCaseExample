using ServiceStack;
using SnakeCaseExample.ServiceModel;

namespace SnakeCaseExample.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { MyResult = $"Hello, {request.Name}!" };
    }
}