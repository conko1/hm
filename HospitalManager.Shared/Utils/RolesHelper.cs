namespace HospitalManager.Shared.Utils;

public static class RolesHelper
{
    public static string TranslateRoleToString(Roles role)
    {
        switch (role)
        {
            case Roles.Admin: return "Admin";
            case Roles.Patient: return "Patient";
            case Roles.Doctor: return "Doctor";
            default: return string.Empty;
        }
    }
    
    public static Roles TranslateRoleFromString(string role)
    {
        switch (role)
        {
            case "Admin": return Roles.Admin;
            case "Pacient": return Roles.Patient;
            case "Doktor": return Roles.Doctor;
            default: return Roles.Unknown;
        }
    }
}