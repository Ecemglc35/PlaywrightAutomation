using Microsoft.Playwright;

namespace PlaywrightAutomation.DemoQA.Pages;
public class TextBoxPage
{
    private readonly IPage page;

    public TextBoxPage(IPage page)
    {
        this.page = page;
    }
    #region Locators
    public ILocator FullNameTextBox => page.GetByRole(AriaRole.Textbox, new(){Name = "Full Name"});
    public ILocator EmailTextBox => page.GetByRole(AriaRole.Textbox, new(){Name = "name@example.com"});
    public ILocator CurrentAddressTextBox => page.GetByRole(AriaRole.Textbox, new(){Name = "Current Address"});
    public ILocator PermenantAddressTextBox => page.Locator("//textarea[contains(@id, 'permanentAddress')]");
    public ILocator SubmitButton => page.GetByRole(AriaRole.Button, new(){ Name = "Submit" });
    public ILocator FullNameSubmissionField => page.Locator("//p[contains(@id, 'name')]");
    public ILocator EmailSubmissionField => page.Locator("//p[contains(@id, 'email')]");
    public ILocator CurrentAddressSubmissionField => page.Locator("//p[contains(@id, 'currentAddress')]");
    public ILocator PermenantAddressSubmissionField => page.Locator("//p[contains(@id, 'permanentAddress')]");
    #endregion 

    #region Methods
    public async Task FillFullNameTextBox(string fullName) => await FullNameTextBox.FillAsync(fullName);
    public async Task FillEmailTextBox(string email) => await EmailTextBox.FillAsync(email);
    public async Task FillCurrentAddressTextBox(string currentAddress) => await CurrentAddressTextBox.FillAsync(currentAddress);

    public async Task FillPermenantAddressTextBox(string permenantAddress) => await PermenantAddressTextBox.FillAsync(permenantAddress);
    public async Task ClickSubmit() => await SubmitButton.ClickAsync();

    public async Task VerifyFormSubmissionIsVisible(string fullName, string email, string currentAddress, string permenantAddress)
    {
        await FullNameSubmissionField.WaitForAsync();
        await EmailSubmissionField.WaitForAsync();
        await CurrentAddressSubmissionField.WaitForAsync();
        await PermenantAddressSubmissionField.WaitForAsync();

        var actualFullName = await FullNameSubmissionField.TextContentAsync();
        var actualEmail = await EmailSubmissionField.TextContentAsync();
        var actualCurrentAddress = await CurrentAddressSubmissionField.TextContentAsync();
        var actualPermenantAddress = await PermenantAddressSubmissionField.TextContentAsync();

        Assert.IsTrue(actualFullName?.Contains(fullName), $"Full Name: {actualFullName}submission field is not visible or does not contain the expected value!");
        Assert.IsTrue(actualEmail?.Contains(email), $"Email: {actualEmail}submission field is not visible or does not contain the expected value!");
        Assert.IsTrue(actualCurrentAddress?.Contains(currentAddress), $"Current Address: {actualCurrentAddress}submission field is not visible or does not contain the expected value!");
        Assert.IsTrue(actualPermenantAddress?.Contains(permenantAddress), $"Permanent Address: {actualPermenantAddress}submission field is not visible or does not contain the expected value!");
    }

    #endregion
}