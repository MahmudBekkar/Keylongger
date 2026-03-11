# WindowsSecurity

A C# WinForms application that demonstrates keyboard event monitoring and log handling in a desktop environment.

This project was created for educational purposes to explore:

- Windows API usage
- Keyboard event handling
- Logging systems
- SMTP-based email notifications
- Secure credential handling with Environment Variables

## Features

- Global keyboard event monitoring
- Log collection system
- Email notification support with SMTP
- Secure credential storage using Environment Variables
- WinForms-based desktop interface

## Technologies Used

| Technology | Purpose |
|------------|---------|
| C# | Main programming language |
| .NET WinForms | Desktop interface |
| Windows API (user32.dll) | Keyboard event monitoring |
| SMTP | Sending email notifications |
| Environment Variables | Secure credential storage |

## Why Environment Variables?

Hardcoding sensitive data like email passwords directly in source code is unsafe.

### Unsafe Example

```csharp
client.Credentials = new NetworkCredential("mail@gmail.com", "password");
