# StudyZone

**StudyZone** is a productivity application designed to help you manage your study sessions effectively using the Pomodoro Technique. Enhance your focus, organize your tasks, and monitor your productivity with StudyZone's intuitive features.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
  - [Prerequisites](#prerequisites)
  - [Installation Methods](#installation-methods)
    - [Method 1: Installing via Releases](#method-1-installing-via-releases)
    - [Method 2: Building from Source](#method-2-building-from-source)
- [Usage](#usage)
  - [Setting Up a Study Session](#setting-up-a-study-session)
  - [Managing Tasks](#managing-tasks)
  - [Setting Reminders](#setting-reminders)
  - [Using the Mini Timer](#using-the-mini-timer)
  - [Viewing Session Logs](#viewing-session-logs)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Disclaimer](#disclaimer)

## Features

- **Session Timer**: Customize your study and break durations to suit your preferences.
- **Task Manager**: Keep track of your study tasks, set due dates, and assign them to specific sessions.
- **Reminders**: Create one-time or recurring reminders for important events.
- **Mini Timer**: Use a compact timer window that stays on top for convenience.
- **Session Logs**: Review your past study sessions and monitor your productivity.
- **Notifications**: Get notified about tasks that are due soon or overdue.
- **System Tray Integration**: Minimize the app to the system tray for quick access.
- **Customizable Settings**: Enable startup with Windows and adjust other preferences.

## Installation

### Prerequisites

Before installing **StudyZone**, ensure you have the following prerequisites:

- **Operating System**: Windows 10 or higher
- **.NET Framework**: .NET 5.0 or higher (if building from source)
- **Internet Connection**: Required for downloading dependencies and updates

### Installation Methods

You can install **StudyZone** using one of the following methods based on your preference:

#### Method 1: Installing via Releases

If you prefer not to build the application from source, you can download precompiled releases.

1. **Navigate to the Releases Page**:

    - Go to the [StudyZone Releases](https://github.com/MohammedTsmu/StudyZone/releases) page on GitHub.

2. **Download the Latest Release**:

    - Find the latest stable release (e.g., `StudyZone-v1.0.0-setup.exe`).
    - Download the appropriate installer for your operating system.

3. **Run the Installer**:

    - **Windows**:
        - Double-click the downloaded `.exe` file.
        - Follow the on-screen instructions to install StudyZone on your Windows machine.
    - **macOS/Linux**:
        - If available, follow the provided instructions or extract the downloaded archive.
        - Ensure you have the necessary permissions to run the executable.

4. **Launch the Application**:

    - After installation, launch **StudyZone** from the Start Menu or desktop shortcut.

#### Method 2: Building from Source

Follow these steps to build and run the application from the source code.

1. **Clone the Repository**:

    ```bash
    git clone https://github.com/MohammedTsmu/StudyZone.git
    ```

2. **Open the Project in Visual Studio**:

    - Navigate to the cloned repository folder.
    - Open the `StudyZone.sln` solution file with Visual Studio.

3. **Restore NuGet Packages**:

    - If prompted, restore the required NuGet packages to ensure all dependencies are installed.

4. **Build the Solution**:

    - In Visual Studio, build the solution by selecting **Build > Build Solution** or pressing `Ctrl+Shift+B`.

5. **Run the Application**:

    - Start the application from Visual Studio by pressing `F5` or selecting **Debug > Start Debugging**.

## Usage

### Setting Up a Study Session

1. **Set Study and Break Durations**:

    - Use the numeric up-down controls to set your desired study and break times.

2. **Start the Session**:

    - Click the **Start** button to begin the study session.

3. **Pause/Resume the Session**:

    - Use the **Pause** button to pause the timer and **Resume** to continue.

4. **Stop the Session**:

    - Click the **Stop** button to end the session prematurely.

### Managing Tasks

1. **Open Task Manager**:

    - Click on the **Task Manager** button to open the task management window.

2. **Add New Task**:

    - Click **Add Task**, fill in the details like title, description, due date, and assign it to a session.

3. **Edit or Delete Tasks**:

    - Select a task from the list and choose **Edit** or **Delete** as needed.

4. **Mark Tasks as Completed**:

    - Check the box next to a task to mark it as completed.

### Setting Reminders

1. **Open Reminders**:

    - Click on the **Reminders** button to manage your reminders.

2. **Add New Reminder**:

    - Click **Add Reminder**, enter the reminder name, set the time, and choose if it’s recurring.

3. **Edit or Delete Reminders**:

    - Select a reminder from the list and choose **Edit** or **Delete**.

### Using the Mini Timer

1. **Open Mini Timer**:

    - Click on the **Mini Timer** button to open the compact timer window.

2. **Control Session**:

    - Start, pause, or stop the session directly from the mini timer.

3. **Stay Focused**:

    - The mini timer stays on top, allowing you to keep track of time while working in other applications.

### Viewing Session Logs

1. **Open Session Logs**:

    - Click on the **Session Logs** button to view your study history.

2. **Review Past Sessions**:

    - Browse through the logs to analyze your study patterns and productivity.

3. **Export Logs (Optional)**:

    - Export your session logs to a file for external analysis (feature to be implemented).

## Screenshots

### Main Interface of StudyZone

![Main Interface](https://github.com/MohammedTsmu/StudyZone/blob/master/screenshots/main-interface.png)  
*Figure: Main Interface of StudyZone*

### Task Manager Window

![Task Manager](https://github.com/MohammedTsmu/StudyZone/blob/master/screenshots/task-manager.png)  
*Figure: Task Manager Window*

### Mini Timer in Action

![Mini Timer](https://github.com/MohammedTsmu/StudyZone/blob/master/screenshots/mini-timer.png)  
*Figure: Mini Timer in Action*

## Contributing

Contributions are welcome! If you have ideas for improvements or new features, feel free to open an issue or submit a pull request.

### Steps to Contribute

1. **Fork the Repository**:

    - Click the **Fork** button at the top-right corner of the repository page on GitHub.

2. **Create a Feature Branch**:

    ```bash
    git checkout -b feature/YourFeature
    ```

3. **Commit Your Changes**:

    ```bash
    git commit -m "Add your message"
    ```

4. **Push to the Branch**:

    ```bash
    git push origin feature/YourFeature
    ```

5. **Open a Pull Request**:

    - Navigate to your forked repository on GitHub.
    - Click on **Compare & pull request**.
    - Provide a clear description of your changes and submit the pull request.

## License

This project is licensed under the [AGPL-3.0-1](https://github.com/MohammedTsmu/StudyZone?tab=AGPL-3.0-1-ov-file).

## Contact

**Developer**: Dr. Mohammed Qasim

Feel free to reach out for any questions or feedback!

## Disclaimer

This application is provided as-is without any guarantees or warranty. Use it at your own risk.

Thank you for using **StudyZone**! We hope it helps you achieve your study goals.
