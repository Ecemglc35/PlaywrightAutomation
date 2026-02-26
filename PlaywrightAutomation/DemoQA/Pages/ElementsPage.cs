using Microsoft.Playwright;

namespace PlaywrightAutomation.DemoQA.Pages;
public class ElementsPage
{
    private readonly IPage page;

    public ElementsPage(IPage page)
    {
        this.page = page;
    }
    #region Locators
    public  ILocator ElementsFeature => page.Locator("//span[contains(text(), 'Elements')]");
    public ILocator TextBoxSubFeature => page.GetByRole(AriaRole.Link, new() { Name = "Text Box" });
    #endregion

    #region Methods
    public async Task ClickElementsFeature() => await ElementsFeature.ClickAsync();
    public async Task ClickTextBoxSubFeature() => await TextBoxSubFeature.ClickAsync();
    #endregion
}