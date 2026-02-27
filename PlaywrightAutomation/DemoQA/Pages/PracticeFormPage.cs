using Microsoft.Playwright;

namespace PlaywrightAutomation.DemoQA.Pages;

public class PracticeFormPage : CommonPage
{
    private readonly IPage page;

    public PracticeFormPage(IPage page) : base(page)    
    {
        this.page = page;
    }

    #region Locators
    public ILocator FirstNameTextBox => TextBox("First Name");
    public ILocator LastNameTextBox => TextBox("Last Name");
    public ILocator GenderRadioButton(string gender) => RadioButton(gender);
    public ILocator MobileNumberTextBox => TextBox("Mobile Number");
    public ILocator DateOfBirthTextBox => page.Locator("//input[contains(@id,'dateOfBirthInput')]");
    public ILocator SubjectInput => page.Locator("//input[contains(@id,'subjectsInput')]");
    public ILocator HobbiesCheckbox(string hobby) => CheckBox(hobby);
    public ILocator PictureUploadButton => page.Locator("//input[contains(@id,'uploadPicture')]");
    public ILocator CurrentAddressTextArea => TextBox("Current Address");
    public ILocator StateDropdown => page.Locator("//*[contains(text(),'Select State')]");
    public ILocator CityDropdown => page.Locator("//*[contains(text(),'Select City')]");
    public ILocator SubmitButton => Button("Submit");
    
    #endregion  


    #region Methods
    public async Task<bool> IsHeaderVisible(string name) => await Header(name).IsVisibleAsync();
    public async Task<bool> AreGenderRadioButtonsVisible()
    { 
        bool isMaleVisible = await GenderRadioButton("Male").IsVisibleAsync();
        bool isFemaleVisible = await GenderRadioButton("Female").IsVisibleAsync();
        bool isOtherVisible = await GenderRadioButton("Other").IsVisibleAsync();
        
        return isMaleVisible && isFemaleVisible && isOtherVisible;
    }
    public async Task<bool> AreHobbiesCheckboxesVisible()
    {
        bool isSportsVisible = await HobbiesCheckbox("Sports").IsVisibleAsync();
        bool isReadingVisible = await HobbiesCheckbox("Reading").IsVisibleAsync();
        bool isMusicVisible = await HobbiesCheckbox("Music").IsVisibleAsync();

        return isSportsVisible && isReadingVisible && isMusicVisible;
    }

    #endregion
}