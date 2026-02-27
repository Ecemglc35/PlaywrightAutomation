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

    // This test covers the following acceptance criteria:
    // 1. Verify that the user can successfully submit the Text Box form with valid data
    // 2. Verify that the submitted data is displayed correctly on the page after submission
    // 3. Verify that all required fields(Full Name, Email, Current Address, Permanent Address) are visible and can be filled before submission
    [TestMethod]
    public async Task VerifyUserCanSuccessfullySubmitTheTextBoxFormWithValidData()
    {
       await homePage.ClickElementsButton();
       await elementsPage.ClickTextBoxSubFeature();
        var fullName = "John";
        var email = "john@example.com";
        var currentAddress = "Address Line 1";
        var permenantAddress = "Address Line 2";

        // Check all fields and buttons are visible before filling the form
        Assert.IsTrue(await textBoxPage.FullNameTextBox.IsVisibleAsync(), "Full Name submission field is not visible!");
        Assert.IsTrue(await textBoxPage.EmailTextBox.IsVisibleAsync(), "Email submission field is not visible!");
        Assert.IsTrue(await textBoxPage.CurrentAddressTextBox.IsVisibleAsync(), "Current Address submission field is not visible!");
        Assert.IsTrue(await textBoxPage.PermenantAddressTextBox.IsVisibleAsync(), "Permanent Address submission field is not visible!");
        Assert.IsTrue(await textBoxPage.SubmitButton.IsVisibleAsync(), "Submit button is not visible!");

        await textBoxPage.FillFullNameTextBox(fullName);
        await textBoxPage.FillEmailTextBox(email);
        await textBoxPage.FillCurrentAddressTextBox(currentAddress);
        await textBoxPage.FillPermenantAddressTextBox(permenantAddress);
        await textBoxPage.ClickSubmit();

        await textBoxPage.VerifyFormSubmissionIsVisible(fullName, email, currentAddress, permenantAddress);
    } 

}