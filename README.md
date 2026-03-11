# Keylogger Project

A C# WinForms application developed for educational purposes to explore keyboard event tracking and basic logging techniques in Windows.

This project demonstrates how keyboard events can be captured and processed inside a desktop application.

## Project Description

The application uses Windows API functions to detect keyboard input and log pressed keys.  
After collecting a certain number of keystrokes, the program sends the collected log using SMTP email.

This project was created as part of a learning exercise in:

- Windows Forms development
- Windows API interaction
- Event handling in C#
- Basic logging systems
- Email communication using SMTP

## Features

- Keyboard input tracking
- Log collection system
- Automatic email sending after a number of keystrokes
- CapsLock detection for uppercase characters
- Support for numbers, letters and special characters
- WinForms application structure

## Technologies Used

| Technology | Purpose |
|-----------|--------|
| C# | Main programming language |
| .NET WinForms | Desktop application framework |
| Windows API (user32.dll) | Detect keyboard events |
| SMTP | Send log data via email |
| Visual Studio | Development environment |

## How It Works

1. The application starts and initializes keyboard tracking.
2. Each key press is captured and added to a log string.
3. The program keeps counting the pressed keys.
4. When the number of captured keys exceeds a specific limit, the log is sent by email.

## Educational Purpose

This project was created to practice:

- Windows Forms programming
- Working with keyboard hooks
- Logging user input
- Sending emails from a C# application
- Understanding event-driven programming

## Author

Mahmud Bekkar
