# Repository instructions

## Solution description

- The solution provides a Windows Forms application for:
  - getting publicly available public transport schedules and traffic info via API calls,
  - storing long-lived data in a database,
  - displaying long-lived and live data in a user-friendly way.
- Roadmap and assumptions:
  - The current iteration is a self-training solution. The main exercise areas are Windows Forms, C# asynchronous programming, API calls, and Entity Framework.
  - The solution should follow Clean Architecture principles. They may not be fully implemented in the current iteration, but new code should be designed with them in mind.
  - The solution should be designed with testability in mind. Tests may be absent in the current iteration, but new code should remain testable.
  - Future iterations may add other presentation layers, such as web and Android applications.
  - The current iteration is a monolithic Windows Forms application. Future iterations may move to a frontend-backend architecture exposed through APIs.
- Current projects:
  - `ScheduleSync.Presentation.WinForms` - Windows Forms application targeting .NET Framework 4.8.1.
  - `ScheduleSync.Infrastructure` - contains code that is not dependent on Windows Forms.
	- The Windows Forms project currently references Infrastructure and calls its methods directly.
	- In future iterations, Infrastructure may be split into separate projects to better follow Clean Architecture principles and support a frontend-backend architecture.

## Change guidance

- Preserve compatibility with .NET Framework 4.8.1 and the project's existing compiler/toolchain. Do not upgrade the target framework or project format unless asked.
- Follow the existing C# style and make focused changes that fit the current application structure.
- Keep Windows Forms designer-generated layout code in `*.Designer.cs`; put event handling and application behavior in the corresponding form code file where practical.
- Keep UI event handlers responsive. Use asynchronous APIs for operations that may take significant time, and avoid blocking the UI thread.
- Do not add packages, projects, or broad abstractions unless the change requires them.

## Validation

- Build the solution or `ScheduleSync.Presentation.WinForms` project after making code changes.
- Run relevant tests when available. Do not claim tests were run if no test project or test runner is available.

## Other

- The README currently provides no additional product or architecture details; avoid assuming requirements that are not represented in the code or the user's request.

