namespace HospitalManager.IDP.Services;

public interface IRegistrationTokenHandler
{
    public string getToken();
    public void setToken(string token);
}