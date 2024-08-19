using System.Net;
using System.Text.Json.Serialization;

namespace BA.Result;

public sealed class Http400Result<T>
{
    public T? Data { get; private set; }
    public List<string>? ErrorMessages { get; private set; }
    public bool IsSuccessful { get; private set; } = false;

    [JsonIgnore]
    public HttpStatusCode StatusCode { get; private set; } = HttpStatusCode.BadRequest;

    private Http400Result(T data)
    {
        Data = data;
    }

    private Http400Result(HttpStatusCode statusCode, List<string> errorMessages)
    {
        StatusCode = statusCode;
        ErrorMessages = errorMessages;
    }

    private Http400Result(HttpStatusCode statusCode, string errorMessage)
    {
        StatusCode = statusCode;
        ErrorMessages = new() { errorMessage };
    }

    public static implicit operator Http400Result<T>(T data)
    {
        return new Http400Result<T>(data);
    }

    public static implicit operator Http400Result<T>((HttpStatusCode statusCode, List<string> errorMessages) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessages);
    }

    public static implicit operator Http400Result<T>((HttpStatusCode statusCode, string errorMessage) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessage);
    }

    public static Http400Result<T> BadRequest400(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.BadRequest
        };
    }

    public static Http400Result<T> BadRequest400(string errorMessage)
    {
        return new(HttpStatusCode.BadRequest, errorMessage);
    }

    public static Http400Result<T> BadRequest400(List<string> errorMessages)
    {
        return new(HttpStatusCode.BadRequest, errorMessages);
    }

    public static Http400Result<T> Unauthorized401(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.Unauthorized
        };
    }

    public static Http400Result<T> Unauthorized401(string errorMessage)
    {
        return new(HttpStatusCode.Unauthorized, errorMessage);
    }

    public static Http400Result<T> Unauthorized401(List<string> errorMessages)
    {
        return new(HttpStatusCode.Unauthorized, errorMessages);
    }

    public static Http400Result<T> Forbidden403(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.Forbidden
        };
    }

    public static Http400Result<T> Forbidden403(string errorMessage)
    {
        return new(HttpStatusCode.Forbidden, errorMessage);
    }

    public static Http400Result<T> Forbidden403(List<string> errorMessages)
    {
        return new(HttpStatusCode.Forbidden, errorMessages);
    }

    public static Http400Result<T> NotFound404(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.NotFound
        };
    }

    public static Http400Result<T> NotFound404(string errorMessage)
    {
        return new(HttpStatusCode.NotFound, errorMessage);
    }

    public static Http400Result<T> NotFound404(List<string> errorMessages)
    {
        return new(HttpStatusCode.NotFound, errorMessages);
    }

    public static Http400Result<T> MethodNotAllowed405(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.MethodNotAllowed
        };
    }

    public static Http400Result<T> MethodNotAllowed405(string errorMessage)
    {
        return new(HttpStatusCode.MethodNotAllowed, errorMessage);
    }

    public static Http400Result<T> MethodNotAllowed405(List<string> errorMessages)
    {
        return new(HttpStatusCode.MethodNotAllowed, errorMessages);
    }
}
