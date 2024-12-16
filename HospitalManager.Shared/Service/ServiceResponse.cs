namespace HospitalManager.Shared.Service;

public class ServiceResponse<T>
{
    public bool IsSuccess { get; private set; }
    public T Data { get; private set; }
    public int StatusCode { get; private set; }
    public List<string> Errors { get; private set; } = new List<string>();

    // Success response with data
    public static ServiceResponse<T> Success(T data)
    {
        return new ServiceResponse<T> { IsSuccess = true, Data = data };
    }

    // Success response without data
    public static ServiceResponse<T> Success()
    {
        return new ServiceResponse<T> { IsSuccess = true };
    }

    // Failure response with a single error message
    public static ServiceResponse<T> Failure(string error, int code)
    {
        return new ServiceResponse<T> { IsSuccess = false, Errors = new List<string> { error }, StatusCode = code };
    }

    // Failure response with multiple error messages
    public static ServiceResponse<T> Failure(List<string> errors, int code)
    {
        return new ServiceResponse<T> { IsSuccess = false, Errors = errors, StatusCode = code};
    }
}

public class ServiceResponse
{
    public bool IsSuccessful { get; private set; }
    public int StatusCode { get; private set; }
    public List<string> Errors { get; private set; } = new List<string>();

    public static ServiceResponse Success()
    {
        return new ServiceResponse { IsSuccessful = true };
    }

    public static ServiceResponse Failure(string error, int code)
    {
        return new ServiceResponse { IsSuccessful = false, Errors = new List<string> { error }, StatusCode = code };
    }

    public static ServiceResponse Failure(List<string> errors, int code)
    {
        return new ServiceResponse { IsSuccessful = false, Errors = errors, StatusCode = code };
    }
}