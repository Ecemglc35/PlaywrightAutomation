using Microsoft.Playwright;
using PlaywrightAutomation.DemoQA.Pages;

namespace PlaywrightAutomation.Framework;

public abstract class TestBase
{
    public IPlaywright playwright;
    public IBrowser browser;
    public IPage page;
    public HomePage homePage;

    [TestInitialize]
    public async Task Setup()
    {
        playwright = await Playwright.CreateAsync();
        browser = await BrowserFactory.LaunchBrowser(playwright);
        page = await browser.NewPageAsync();
        homePage = new HomePage(page);
        await homePage.NavigateHome();
    }

    [TestCleanup]
    public async Task TearDown()
    {
        await browser.CloseAsync();
        playwright.Dispose();
    }
}