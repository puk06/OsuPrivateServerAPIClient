namespace PrivateServerClient.Core.Models;

public class PrivateServer(string serverEndpoint)
{
    public string ServerAddress { get; private set; } = serverEndpoint;
    public string ServerApiAddress => $"https://api.{ServerAddress}";

    public string ServerApiAddressV1 => $"{ServerApiAddress}/v1";
    public string ServerApiAddressV2 => $"{ServerApiAddress}/v2";
}
