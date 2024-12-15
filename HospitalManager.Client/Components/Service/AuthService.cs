using System.Net.Http.Json;
using HospitalManager.IDP.Entities;

namespace HospitalManager.Client.Components.Service;

public class AuthService
{
    private readonly HttpClient _httpClient;
    
    public User? CurrentUser { get; set; }
    public string? Authtoken { get; set; }
    public bool IsAutentificated => CurrentUser != null;
}