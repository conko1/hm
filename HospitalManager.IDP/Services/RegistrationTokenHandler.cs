namespace HospitalManager.IDP.Services;

public class RegistrationTokenHandler : IRegistrationTokenHandler
{
    private string _registrationToken;
    
    public string getToken()
    {
        return _registrationToken;
    }

    public void setToken(string token)
    {
        _registrationToken = token;
    }
}