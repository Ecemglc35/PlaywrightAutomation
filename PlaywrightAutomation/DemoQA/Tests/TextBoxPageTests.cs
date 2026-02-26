using PlaywrightAutomation.DemoQA.Pages;
using PlaywrightAutomation.Framework;

namespace PlaywrightAutomation.DemoQA.Tests;

[TestClass]
public class TextBoxTests : TestBase
{
    private TextBoxPage textBoxPage;
private ElementsPage elementsPage;

    [TestInitialize]
    public async Task TestSetup()
    {
        textBoxPage = new TextBoxPage(page);
        elementsPage = new ElementsPage(page);
    }

    [TestMethod]
    public async Task VerifyUserCanSuccessfullySubmitTheTextBoxFormWithValidData()
    {
       await homePage.ClickElementsButton();
       await elementsPage.ClickTextBoxSubFeature();
        var fullName = "John";
        var email = "john@example.com";
        var currentAddress = "Address Line 1";
        var permenantAddress = "Address Line 2";

        await textBoxPage.FillFullNameTextBox(fullName);
        await textBoxPage.FillEmailTextBox(email);
        await textBoxPage.FillCurrentAddressTextBox(currentAddress);
        await textBoxPage.FillPermenantAddressTextBox(permenantAddress);
        await textBoxPage.ClickSubmit();

        await textBoxPage.VerifyFormSubmissionIsVisible(fullName, email, currentAddress, permenantAddress);
    }
}