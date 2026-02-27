using System.Security.AccessControl;
using Microsoft.Playwright;

namespace PlaywrightAutomation.DemoQA.Pages;

public class CommonPage
{
    private readonly IPage page;

    public CommonPage(IPage page)
    {
        this.page = page;
    }

    #region Locators
    public ILocator Button(string name) => page.GetByRole(AriaRole.Button, new() { Name = name });
    public ILocator Header(string name) => page.GetByRole(AriaRole.Heading, new() { Name = name });
    public ILocator TextBox(string name) => page.GetByRole(AriaRole.Textbox, new() { Name = name });
    public ILocator CheckBox(string name) => page.GetByRole(AriaRole.Checkbox, new() { Name = name });
    public ILocator RadioButton(string name) => page.GetByRole(AriaRole.Radio, new() { Name = name , Exact = true });
    public ILocator Link(string name) => page.GetByRole(AriaRole.Link, new() { Name = name });
    public ILocator EmailTextBox => page.Locator("//input[contains(@id,'userEmail')]");
    #endregion  

    #region Methods

    #endregion
}