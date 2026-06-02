using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
namespace Praktikum02.Blasor.Data;

public class LoginService
{
    private readonly string filePath;
    public bool IsLoggedIn { get; private set; }
    public string? UserName { get; private set; }
    public LoginService(IWebHostEnvironment environment)
    {
        var folderPath = Path.Combine(environment.ContentRootPath, "App_Data");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        filePath = Path.Combine(folderPath, "users.json");

        CreateDefaultUserIfFileDoesNotExist();
    }

    public bool Register(string userName, string password)
    {
        userName = NormalizeUserName(userName);

        if (string.IsNullOrWhiteSpace(userName))
            return false;
        if (string.IsNullOrWhiteSpace(password))
            return false;
        var users = LoadUsers();
        if (users.ContainsKey(userName))
            return false;
        users.Add(userName, password);
        SaveUsers(users);
        return true;
    }

    public bool Login(string userName, string password)
    {
        userName = NormalizeUserName(userName);
        var users = LoadUsers();

        if (users.TryGetValue(userName, out var savedPassword)
            && savedPassword == password)
        {
            IsLoggedIn = true;
            UserName = userName;
            return true;
        }
        return false;
    }
    public void RestoreLogin(string userName)
    {
        userName = NormalizeUserName(userName);
        if (!string.IsNullOrWhiteSpace(userName))
        {
            IsLoggedIn = true;
            UserName = userName;
        }
    }
    public void Logout()
    {
        IsLoggedIn = false;
        UserName = null;
    }
    private Dictionary<string, string> LoadUsers()
    {
        if (!File.Exists(filePath))
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "admin", "1234" }
            };
        }
        var json = File.ReadAllText(filePath);
        var loadedUsers = JsonSerializer.Deserialize<Dictionary<string, string>>(json)
            ?? new Dictionary<string, string>();
        var users = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var user in loadedUsers)
        {
            var userName = NormalizeUserName(user.Key);

            if (!string.IsNullOrWhiteSpace(userName))
            {
                users[userName] = user.Value;
            }
        }
        return users;
    }
    private void SaveUsers(Dictionary<string, string> users)
    {
        var json = JsonSerializer.Serialize(users, new JsonSerializerOptions
        {
           WriteIndented = true
        });
        File.WriteAllText(filePath, json);
    }
    private void CreateDefaultUserIfFileDoesNotExist()
    {
        if (File.Exists(filePath))
            return;
        var users = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "admin", "1234" }
        };
        SaveUsers(users);
    }
    private static string NormalizeUserName(string userName)
    {
        return userName.Trim().ToLower();
    }
}