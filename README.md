# BA.Result

# HTTP Status Code Result Classes

This project contains specialized result classes for HTTP status codes. These classes standardize API responses, making it easier to manage both successful and failed situations. Each class represents responses for specific HTTP status codes and manages the response's status and error messages.

## Contents

1. `Http200Result<T>`
2. `Http300Result<T>`
3. `Http400Result<T>`
4. `Http500Result<T>`

## Usage

### `Http200Result<T>`

`Http200Result<T>`, represents the successful status codes in the HTTP 200 series. It encapsulates a successfully completed operation and the associated data. This class is used for the following status codes:

- 200 OK
- 201 Created
- 202 Accepted
- 204 No Content
- 206 Partial Content

**Example Usage:**

```csharp

var result = Http200Result<string>.Success("Operation completed successfully.");

var createdResult = Http200Result<string>.Created201("New data has been created.");

var noContentResult = Http200Result<string>.NoContent204();

```

### `Http300Result<T>`

`Http300Result<T>`, represents the redirection status codes in the HTTP 300 series. It typically indicates that a resource has been moved or redirected to another location. This class is used for the following status codes:

- 300 Multiple Choices
- 301 Moved Permanently
- 302 Found
- 303 See Other
- 304 Not Modified
- 305 Use Proxy
- 307 Temporary Redirect

**Example Usage:**

```csharp

var movedPermanentlyResult = Http300Result<string>.MovedPermanently301("New address.");

```

### `Http400Result<T>`

`Http400Result<T>`, Http400Result<T> represents the error status codes in the HTTP 400 series. It indicates client-side errors, usually meaning the request is incorrect or incomplete. This class is used for the following status codes:

- 400 Bad Request
- 401 Unauthorized
- 403 Forbidden
- 404 Not Found
- 405 Method Not Allowed

**Example Usage:**

```csharp

var badRequestResult = Http400Result<string>.BadRequest400("Invalid request.");

var notFoundResult = Http400Result<string>.NotFound404("Resource not found.");

```

### `Http500Result<T>`

`Http500Result<T>`, represents the server error status codes in the HTTP 500 series. It indicates a problem on the server side, generally representing server errors. This class is used for the following status codes:

- 500 Internal Server Error
- 501 Not Implemented
- 502 Bad Gateway
- 503 Service Unavailable
- 504 Gateway Timeout
- 505 HTTP Version Not Supported

**Example Usage:**

```csharp

var internalServerErrorResult = Http500Result<string>.InternalServerError500("Server error.");

var serviceUnavailableResult = Http500Result<string>.ServiceUnavailable503("Service temporarily unavailable.");

```

## Installation and Usage

- Open the project in Visual Studio.
- Include the files containing the HTTP status code classes in your project structure.
- Use the relevant classes to standardize your API responses.
These classes utilize the System.Net and System.Text.Json.Serialization libraries to manage HTTP responses and status codes.


# HTTP Durum Kodları İçin Sınıflar

Bu proje, HTTP durum kodları için özel sonuç sınıflarını içerir. Bu sınıflar, API yanıtlarını standartlaştırarak hem başarılı hem de başarısız durumları yönetmeyi kolaylaştırır. Her bir sınıf, belirli bir HTTP durum kodu için yanıtları temsil eder ve yanıtın durumunu ve hata mesajlarını yönetir.

## İçerik

1. `Http200Result<T>`
2. `Http300Result<T>`
3. `Http400Result<T>`
4. `Http500Result<T>`

## Kullanım

### `Http200Result<T>`

`Http200Result<T>`, HTTP 200 serisindeki başarılı durum kodlarını temsil eder. Başarıyla gerçekleşmiş bir işlemi ve ilgili veriyi kapsar. Bu sınıf, aşağıdaki durum kodları için kullanılır:

- 200 OK
- 201 Created
- 202 Accepted
- 204 No Content
- 206 Partial Content

**Örnek Kullanım:**

```csharp

var result = Http200Result<string>.Success("Başarıyla işlendi.");

var createdResult = Http200Result<string>.Created201("Yeni veri oluşturuldu.");

var noContentResult = Http200Result<string>.NoContent204();

```

### `Http300Result<T>`

`Http300Result<T>`, HTTP 300 serisindeki yönlendirme durum kodlarını temsil eder. Genellikle bir kaynağın başka bir yere taşındığını veya yönlendirildiğini belirtir. Bu sınıf, aşağıdaki durum kodları için kullanılır:

- 300 Multiple Choices
- 301 Moved Permanently
- 302 Found
- 303 See Other
- 304 Not Modified
- 305 Use Proxy
- 307 Temporary Redirect

**Örnek Kullanım:**

```csharp

var movedPermanentlyResult = Http300Result<string>.MovedPermanently301("Yeni adres.");

```

### `Http400Result<T>`

`Http400Result<T>`, HTTP 400 serisindeki hata durum kodlarını temsil eder. İstemci tarafından yapılan hataları ifade eder ve genellikle isteğin yanlış veya eksik olduğunu belirtir. Bu sınıf, aşağıdaki durum kodları için kullanılır:

- 400 Bad Request
- 401 Unauthorized
- 403 Forbidden
- 404 Not Found
- 405 Method Not Allowed

**Örnek Kullanım:**

```csharp

var badRequestResult = Http400Result<string>.BadRequest400("Geçersiz istek.");

var notFoundResult = Http400Result<string>.NotFound404("Kaynak bulunamadı.");

```

### `Http500Result<T>`

`Http500Result<T>`, HTTP 500 serisindeki sunucu hata kodlarını temsil eder. Sunucu tarafında bir sorun olduğunu belirtir ve genellikle sunucu hatalarını ifade eder. Bu sınıf, aşağıdaki durum kodları için kullanılır:

- 500 Internal Server Error
- 501 Not Implemented
- 502 Bad Gateway
- 503 Service Unavailable
- 504 Gateway Timeout
- 505 HTTP Version Not Supported

**Örnek Kullanım:**

```csharp

var internalServerErrorResult = Http500Result<string>.InternalServerError500("Sunucu hatası.");

var serviceUnavailableResult = Http500Result<string>.ServiceUnavailable503("Hizmet geçici olarak kullanılamıyor.");

```

## Kurulum ve Kullanım

- Projeyi Visual Studio'da açın.
- HTTP durum kodları sınıflarını içeren dosyaları proje yapınıza dahil edin.
- İlgili sınıfları kullanarak API yanıtlarınızı standartlaştırın.
Sınıflar, System.Net ve System.Text.Json.Serialization kütüphanelerini kullanarak HTTP yanıtlarını ve durum kodlarını yönetmenize olanak tanır.