# EmployeeApp

This is a simple C# .NET console application that demonstrates:

- Defining an interface (`IQuittable`) with a `Quit()` method.
- Implementing that interface in a concrete class (`Employee`).
- Using polymorphism (an object referenced by its interface type).
- Overloading `==` and `!=` operators to compare Employees by `Id`.
- Thorough inline comments explaining each line / block.

---

## What's included

- `EmployeeApp.csproj` - .NET 7 console project file.
- `IQuittable.cs` - Interface definition.
- `Employee.cs` - Employee class implementing the interface and operator overloads.
- `Program.cs` - Application entry point demonstrating polymorphism.
- `README.md` - this file.

---

## How to run (Novice-friendly, NO command-line required)

### Option A — Visual Studio (recommended for beginners, Windows)

1. Install **Visual Studio 2022** or later with the **.NET desktop development** workload.
2. Download and unzip the provided `EmployeeApp.zip`.
3. In Visual Studio, choose **File → Open → Project/Solution...**
4. Navigate into the unzipped folder and open `EmployeeApp.csproj`.
5. Once the project loads, set the project as the startup project (it usually is by default).
6. Press the green **Start** button or press **F5** to run the application.
7. Observe the console output; press any key to exit.

### Option B — Visual Studio for Mac

1. Install **Visual Studio for Mac** with .NET support.
2. Open `EmployeeApp.csproj` from **File → Open...**
3. Run the project using the Play/Run button.

### Option C — Visual Studio Code (minimal UI interaction, small guidance)

> Note: VS Code often requires the .NET SDK installed on the machine. If you prefer strictly GUI steps without installing SDKs, use Visual Studio (Option A).

1. Install Visual Studio Code and the C# extension (from Microsoft).
2. Open the unzipped folder in VS Code: **File → Open Folder...**
3. If prompted to add required assets for build and debugging, accept.
4. Click the Run and Debug icon on the left, choose `.NET Launch (console)` and press the green triangle.
5. The Debug Console will run the app; use the terminal that appears to view output.

---

## How to upload to GitHub (GUI-only steps using GitHub Desktop)

1. Install [GitHub Desktop](https://desktop.github.com/) (GUI app).
2. Open GitHub Desktop and sign in to your GitHub account.
3. Choose **File → Add local repository...** and point it to the unzipped `EmployeeApp` folder.
4. In GitHub Desktop, type a commit message like "Initial commit - EmployeeApp" and click **Commit to main**.
5. Click **Publish repository** in the top bar, set visibility (public/private), and click **Publish repository** again.
6. Your code is now on GitHub — copy the repository link and submit it.

---

## Notes for instructors / reviewers

- The code contains comments on nearly every line or block to help other developers understand intent.
- The project targets .NET 7.0; if your environment uses another .NET version, update the TargetFramework in the `.csproj` accordingly.

Enjoy! If you want a version that includes a Visual Studio solution (`.sln`) or a different .NET target, tell me and I'll add it.
