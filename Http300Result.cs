using System.Net;
using System.Text.Json.Serialization;

namespace BA.Result;

public sealed class Http300Result<T>
{
    public T? Data { get; private set; }
    public List<string>? ErrorMessages { get; private set; }
    public bool IsSuccessful { get; private set; } = true;

    [JsonIgnore]
    public HttpStatusCode StatusCode { get; private set; } = HttpStatusCode.MultipleChoices;

    private Http300Result(T data)
    {
        Data = data;
    }

    private Http300Result(HttpStatusCode statusCode, List<string> errorMessages)
    {
        IsSuccessful = false;
        StatusCode = statusCode;
        ErrorMessages = errorMessages;
    }

    private Http300Result(HttpStatusCode statusCode, string errorMessage)
    {
        IsSuccessful = false;
        StatusCode = statusCode;
        ErrorMessages = new() { errorMessage };
    }

    public static implicit operator Http300Result<T>(T data)
    {
        return new Http300Result<T>(data);
    }

    public static implicit operator Http300Result<T>((HttpStatusCode statusCode,
        List<string> errorMessages) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessages);
    }

    public static implicit operator Http300Result<T>((HttpStatusCode statusCode,
        string errorMessage) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessage);
    }

    public static Http300Result<T> MultipleChoices300(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.MultipleChoices
        };
    }

    public static Http300Result<T> MultipleChoices300(string errorMessage)
    {
        return new(HttpStatusCode.MultipleChoices, errorMessage);
    }

    public static Http300Result<T> MultipleChoices300(List<string> errorMessages)
    {
        return new(HttpStatusCode.MultipleChoices, errorMessages);
    }

    public static Http300Result<T> MovedPermanently301(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.MovedPermanently
        };
    }

    public static Http300Result<T> MovedPermanently301(string errorMessage)
    {
        return new(HttpStatusCode.MovedPermanently, errorMessage);
    }

    public static Http300Result<T> MovedPermanently301(List<string> errorMessages)
    {
        return new(HttpStatusCode.MovedPermanently, errorMessages);
    }

    public static Http300Result<T> Found302(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.Found
        };
    }

    public static Http300Result<T> Found302(string errorMessage)
    {
        return new(HttpStatusCode.Found, errorMessage);
    }

    public static Http300Result<T> Found302(List<string> errorMessages)
    {
        return new(HttpStatusCode.Found, errorMessages);
    }

    public static Http300Result<T> SeeOther303(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.SeeOther
        };
    }

    public static Http300Result<T> SeeOther303(string errorMessage)
    {
        return new(HttpStatusCode.SeeOther, errorMessage);
    }

    public static Http300Result<T> SeeOther303(List<string> errorMessages)
    {
        return new(HttpStatusCode.SeeOther, errorMessages);
    }

    public static Http300Result<T> NotModified304()
    {
        return new(default!)
        {
            StatusCode = HttpStatusCode.NotModified,
            IsSuccessful = true
        };
    }

    public static Http300Result<T> UseProxy305(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.UseProxy
        };
    }

    public static Http300Result<T> UseProxy305(string errorMessage)
    {
        return new(HttpStatusCode.UseProxy, errorMessage);
    }

    public static Http300Result<T> UseProxy305(List<string> errorMessages)
    {
        return new(HttpStatusCode.UseProxy, errorMessages);
    }

    public static Http300Result<T> TemporaryRedirect307(T data)
    {
        return new(data)
        {
            StatusCode = HttpStatusCode.TemporaryRedirect
        };
    }

    public static Http300Result<T> TemporaryRedirect307(string errorMessage)
    {
        return new(HttpStatusCode.TemporaryRedirect, errorMessage);
    }

    public static Http300Result<T> TemporaryRedirect307(List<string> errorMessages)
    {
        return new(HttpStatusCode.TemporaryRedirect, errorMessages);
    }
}

