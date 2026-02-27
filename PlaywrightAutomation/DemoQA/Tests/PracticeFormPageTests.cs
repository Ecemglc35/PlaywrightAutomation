using PlaywrightAutomation.Framework;
using PlaywrightAutomation.DemoQA.Pages;

namespace PlaywrightAutomation.DemoQA.Tests;
[TestClass]
public class PracticeFormPageTests : TestBase
{
    public PracticeFormPage practiceFormPage;
    public FormsPage formsPage;


     [TestInitialize]
    public async Task TestSetup()
    {
        practiceFormPage = new PracticeFormPage(page);
        formsPage = new FormsPage(page);
    }

    [TestMethod]
    public async Task VerifyAllFieldsIntoPracticeFormPageAreVisible()
    {
        await homePage.ClickFormsButton();
        await formsPage.ClickPracticeFormSubFeature();

        Assert.IsTrue(await practiceFormPage.FirstNameTextBox.IsVisibleAsync(), "First Name text box is not visible!");
        Assert.IsTrue(await practiceFormPage.LastNameTextBox.IsVisibleAsync(), "Last Name text box is not visible!");
        Assert.IsTrue(await practiceFormPage.EmailTextBox.IsVisibleAsync(), "Email text box is not visible!");
        Assert.IsTrue(await practiceFormPage.AreGenderRadioButtonsVisible(), "One or more gender radio buttons are not visible!");
        Assert.IsTrue(await practiceFormPage.MobileNumberTextBox.IsVisibleAsync(), "Mobile Number text box is not visible!");
        Assert.IsTrue(await practiceFormPage.DateOfBirthTextBox.IsVisibleAsync(), "Date of Birth text box is not visible!");
        Assert.IsTrue(await practiceFormPage.SubjectInput.IsVisibleAsync(), "Subject input is not visible!");
        Assert.IsTrue(await practiceFormPage.AreHobbiesCheckboxesVisible(), "One or more hobbies checkboxes are not visible!");
        Assert.IsTrue(await practiceFormPage.PictureUploadButton.IsVisibleAsync(), "Picture upload button is not visible!");
        Assert.IsTrue(await practiceFormPage.CurrentAddressTextArea.IsVisibleAsync(), "Current Address text area is not visible!");
        Assert.IsTrue(await practiceFormPage.StateDropdown.IsVisibleAsync(), "State dropdown is not visible!");
        Assert.IsTrue(await practiceFormPage.CityDropdown.IsVisibleAsync(), "City dropdown is not visible!");
    }

    [TestMethod]
    public async Task VerifyNameMobileNumberFieldsAreRequired()
    {
        await homePage.ClickFormsButton();
        await formsPage.ClickPracticeFormSubFeature();

        // Attempt to submit the form without filling any fields
        await practiceFormPage.SubmitButton.ClickAsync();

        Assert.IsTrue(await practiceFormPage.FirstNameTextBox.GetAttributeAsync("required") != null, "First Name field is not marked as required!");
        Assert.IsTrue(await practiceFormPage.LastNameTextBox.GetAttributeAsync("required")!= null, "Last Name field is not marked as required!");
        Assert.IsTrue(await practiceFormPage.MobileNumberTextBox.GetAttributeAsync("required") != null, "Mobile Number field is not marked as required!");
    }

}