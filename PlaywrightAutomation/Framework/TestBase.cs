using Microsoft.Playwright;

namespace PlaywrightAutomation.Framework;

public abstract class TestBase
{
    public IPlaywright playwright;
    public IBrowser browser;
    public IPage page;

    [TestInitialize]
    public async Task Setup()
    {
        playwright = await Playwright.CreateAsync();
        browser = await BrowserFactory.LaunchBrowser(playwright);
        page = await browser.NewPageAsync();
    }

    [TestCleanup]
    public async Task TearDown()
    {
        await browser.CloseAsync();
        playwright.Dispose();
    }
}