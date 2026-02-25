using Microsoft.Playwright;
using PlaywrightAutomation.Configuration;

namespace PlaywrightAutomation.DemoQA.Pages;

public class HomePage
{
    private readonly IPage page;

    public HomePage(IPage page)
    {
        this.page = page;
    }

    private ILocator ElementsCard => page.GetByRole(AriaRole.Heading, new() { Name = "Elements" } );
    private ILocator FormsCard => page.GetByRole(AriaRole.Heading, new() { Name = "Froms" } );
    private ILocator AlertsFrameWindowsCard => page.Locator("Alerts, Frame & Windows");

    public async Task NavigateHome()
    {
        await page.GotoAsync(TestSettings.homePageUrl);
    }

    public async Task ClickElementsButton()
    {
        await ElementsCard.ClickAsync();
    }

    public async Task ClickFormsButton()
    {
        await FormsCard.ClickAsync();
    }

    public async Task ClickAlertsFrameAndWindowsButton()
    {
        await AlertsFrameWindowsCard.ClickAsync();
    }
}