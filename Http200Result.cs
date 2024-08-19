using System.Net;
using System.Text.Json.Serialization;

namespace BA.Result;

public sealed class Http200Result<T>
{
    public T? Data { get; private set; }
    public List<string>? ErrorMessages { get; private set; }
    public bool IsSuccessful { get; private set; } = true;

    [JsonIgnore]
    public HttpStatusCode StatusCode { get; private set; } = HttpStatusCode.OK;

    private Http200Result(T data)
    {
        Data = data;
    }

    private Http200Result(HttpStatusCode statusCode, List<string> errorMessages)
    {
        IsSuccessful = false;
        StatusCode = statusCode;
        ErrorMessages = errorMessages;
    }

    private Http200Result(HttpStatusCode statusCode, string errorMessage)
    {
        IsSuccessful = false;
        StatusCode = statusCode;
        ErrorMessages = new() { errorMessage };
    }

    public static implicit operator Http200Result<T>(T data)
    {
        return new Http200Result<T>(data);
    }

    public static implicit operator Http200Result<T>((HttpStatusCode statusCode, List<string> errorMessages) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessages);
    }

    public static implicit operator Http200Result<T>((HttpStatusCode statusCode,
        string errorMessage) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessage);
    }

    public static Http200Result<T> Success(T data)
    {
        return new(data);
    }

    public static Http200Result<T> Created201(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.Created
        };
    }

    public static Http200Result<T> Accepted202(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.Accepted
        };
    }

    public static Http200Result<T> Accepted202(string errorMessage)
    {
        return new(HttpStatusCode.Accepted, errorMessage);
    }

    public static Http200Result<T> Accepted202(List<string> errorMessages)
    {
        return new(HttpStatusCode.Accepted, errorMessages);
    }

    public static Http200Result<T> NoContent204()
    {
        return new(default!)
        {
            StatusCode = HttpStatusCode.NoContent,
            IsSuccessful = true
        };
    }

    public static Http200Result<T> PartialContent206(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.PartialContent
        };
    }

    public static Http200Result<T> PartialContent206(string errorMessage)
    {
        return new(HttpStatusCode.PartialContent, errorMessage);
    }

    public static Http200Result<T> PartialContent206(List<string> errorMessages)
    {
        return new(HttpStatusCode.PartialContent, errorMessages);
    }
}

