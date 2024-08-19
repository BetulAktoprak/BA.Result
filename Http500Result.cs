using System.Net;
using System.Text.Json.Serialization;

namespace BA.Result;

public sealed class Http500Result<T>
{
    public T? Data { get; private set; }
    public List<string>? ErrorMessages { get; private set; }
    public bool IsSuccessful { get; private set; } = false;

    [JsonIgnore]
    public HttpStatusCode StatusCode { get; private set; } = HttpStatusCode.InternalServerError;

    private Http500Result(T data)
    {
        Data = data;
    }

    private Http500Result(HttpStatusCode statusCode, List<string> errorMessages)
    {
        StatusCode = statusCode;
        ErrorMessages = errorMessages;
    }

    private Http500Result(HttpStatusCode statusCode, string errorMessage)
    {
        StatusCode = statusCode;
        ErrorMessages = new() { errorMessage };
    }

    public static implicit operator Http500Result<T>(T data)
    {
        return new Http500Result<T>(data);
    }

    public static implicit operator Http500Result<T>((HttpStatusCode statusCode,
        List<string> errorMessages) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessages);
    }

    public static implicit operator Http500Result<T>((HttpStatusCode statusCode,
        string errorMessage) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessage);
    }

    public static Http500Result<T> InternalServerError500(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.InternalServerError
        };
    }

    public static Http500Result<T> InternalServerError500(string errorMessage)
    {
        return new(HttpStatusCode.InternalServerError, errorMessage);
    }

    public static Http500Result<T> InternalServerError500(List<string> errorMessages)
    {
        return new(HttpStatusCode.InternalServerError, errorMessages);
    }

    public static Http500Result<T> NotImplemented501(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.NotImplemented
        };
    }

    public static Http500Result<T> NotImplemented501(string errorMessage)
    {
        return new(HttpStatusCode.NotImplemented, errorMessage);
    }

    public static Http500Result<T> NotImplemented501(List<string> errorMessages)
    {
        return new(HttpStatusCode.NotImplemented, errorMessages);
    }

    public static Http500Result<T> BadGateway502(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.BadGateway
        };
    }

    public static Http500Result<T> BadGateway502(string errorMessage)
    {
        return new(HttpStatusCode.BadGateway, errorMessage);
    }

    public static Http500Result<T> BadGateway502(List<string> errorMessages)
    {
        return new(HttpStatusCode.BadGateway, errorMessages);
    }

    public static Http500Result<T> ServiceUnavailable503(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.ServiceUnavailable
        };
    }

    public static Http500Result<T> ServiceUnavailable503(string errorMessage)
    {
        return new(HttpStatusCode.ServiceUnavailable, errorMessage);
    }

    public static Http500Result<T> ServiceUnavailable503(List<string> errorMessages)
    {
        return new(HttpStatusCode.ServiceUnavailable, errorMessages);
    }

    public static Http500Result<T> GatewayTimeout504(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.GatewayTimeout
        };
    }

    public static Http500Result<T> GatewayTimeout504(string errorMessage)
    {
        return new(HttpStatusCode.GatewayTimeout, errorMessage);
    }

    public static Http500Result<T> GatewayTimeout504(List<string> errorMessages)
    {
        return new(HttpStatusCode.GatewayTimeout, errorMessages);
    }

    public static Http500Result<T> HttpVersionNotSupported505(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.HttpVersionNotSupported
        };
    }

    public static Http500Result<T> HttpVersionNotSupported505(string errorMessage)
    {
        return new(HttpStatusCode.HttpVersionNotSupported, errorMessage);
    }

    public static Http500Result<T> HttpVersionNotSupported505(List<string> errorMessages)
    {
        return new(HttpStatusCode.HttpVersionNotSupported, errorMessages);
    }
}

