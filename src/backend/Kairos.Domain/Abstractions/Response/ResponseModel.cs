namespace Kairos.Domain.Abstractions.Response;
public class ResponseModel<TData>
{
    public int Code = 200;
    public string? Message { get; set; }
    public TData? Data { get; set; }

    [JsonIgnore]
    public bool IsSuccess => Code is >= 200 and <= 299;

    [JsonConstructor]
    public ResponseModel() => Code = 200;
    public ResponseModel(TData? data, int code = 200, string? message = null)
    {
        Data = data;
        Code =  code;
        Message = message;
    }
}
