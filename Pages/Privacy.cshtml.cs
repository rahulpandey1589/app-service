using app_service.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace app_service.Pages;

public class PrivacyModel : PageModel
{   
    public  string? Mode { get; set; }
    public  string? Development { get; set; }

    private readonly ILogger<PrivacyModel> _logger;
    private readonly IOptions<UserSettings> _userSettings;

    public PrivacyModel(
        ILogger<PrivacyModel> logger,
        IOptions<UserSettings> userSettings)
    {
        _logger = logger;
        _userSettings = userSettings;
    }

    public void OnGet()
    {
        Mode = _userSettings.Value.Mode;
        Development = _userSettings.Value.Platform;
    }
}

