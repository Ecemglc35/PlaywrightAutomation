using PlaywrightAutomation.DemoQA.Pages;
using PlaywrightAutomation.Framework;

namespace PlaywrightAutomation.DemoQA.Tests;

[TestClass]
public class HomePageTests : TestBase
{
    private HomePage homePage;

    [TestInitialize]
    public async Task TestSetup()
    {
        homePage = new HomePage(page);
        await homePage.NavigateHome();
    }

    [TestMethod]
    public async Task ShouldHomePageBeVisible()
    {
        var title = await page.TitleAsync();
        Assert.IsTrue(title.Contains("demosite"), "Home page is not visible!");
    }
}