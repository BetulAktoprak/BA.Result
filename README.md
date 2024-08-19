# BA.Result

# HTTP Status Code Result Classes

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