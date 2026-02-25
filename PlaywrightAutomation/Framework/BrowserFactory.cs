using Microsoft.Playwright;
using PlaywrightAutomation.Configuration;

namespace PlaywrightAutomation.Framework;

public static class BrowserFactory
{
    public static async Task<IBrowser> LaunchBrowser(IPlaywright playwright)
    {
        return await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = TestSettings.headless
        });
    }
}