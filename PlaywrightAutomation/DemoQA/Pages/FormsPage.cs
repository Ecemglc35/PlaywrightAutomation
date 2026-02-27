using Microsoft.Playwright;

namespace PlaywrightAutomation.DemoQA.Pages;

public class FormsPage
{
    private readonly IPage page;

    public FormsPage(IPage page)
    {
        this.page = page;
    }

    #region Locators
    public ILocator FormsFeature => page.Locator("//span[contains(text(), 'Forms')]");
    public ILocator PracticeFormSubFeature => page.GetByRole(AriaRole.Link, new() { Name = "Practice Form" });
    #endregion  

    #region Methods
    public async Task ClickFormsFeature() => await FormsFeature.ClickAsync();
    public async Task ClickPracticeFormSubFeature() => await PracticeFormSubFeature.ClickAsync();
    #endregion
}