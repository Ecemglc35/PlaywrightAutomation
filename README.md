# Book Repository Automation Testing

This project is a test automation framework built with Playwright and MSTest to validate UI components on the [DemoQA](https://demoqa.com) website.

## Project Structure

- **Tests/**: Contains all test cases.
- **Pages/**: Page Object Model classes representing different pages.
- **Framework/**: Contains browser setup, shared configurations, and utilities.
- **Utils/**: Helper functions used in the tests.

## Requirements

- .NET 8 SDK or higher
- Playwright CLI (for browser installation)

## Getting Started

1. Clone the repository:
   ```bash
   git clone <repo_url>
   cd <repo_folder>

2. Install Playwright:
   ```bash
   dotnet tool install --global Microsoft.Playwright.CLI
   dotnet playwright install

3. Run the tests:
   VS Code's Test Explorer

## Structure of Tests
Each test is a well-structured scenario located in its own class, using the Page Object Model to separate UI interactions from test logic.

## Contributing
Contributions are welcome! Feel free to fork the repository, make changes, and submit a pull request.
