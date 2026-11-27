# Repository instructions

## Business context

- The solution provides a Windows Forms application for:
  - getting publicly available public transport schedules and traffic info via API calls,
  - storing received data in a database,
  - displaying data in a user-friendly way.
- The current iteration is a self-training solution. The main exercise areas are Windows Forms, C# asynchronous programming, API calls, and Entity Framework.

## Technical context
- Solution contains 2 projects:
  - `ScheduleSync.Presentation.WinForms` - Windows Forms application targeting .NET Framework 4.8.1.
  - `ScheduleSync.Infrastructure` - contains code that is not dependent on Windows Forms (business logic classes, data access, API calls, etc.)
	- The Windows Forms project currently references Infrastructure and calls its methods directly.
	- In future iterations, Infrastructure may be split into separate projects to better follow Clean Architecture principles and support a frontend-backend architecture.
- Data access:
	- data will be stored in a Microsoft SQL Server database
	- data will be accessed via Entity Framework 6.x (EF6) using the Code First approach
	- public API details will be provided later together with detailed requirements

- Roadmap and assumptions:
  - The solution should follow Clean Architecture principles. They may not be fully implemented in the current iteration, but new code should be designed with them in mind.
  - The solution should be designed with testability in mind. Tests may be absent in the current iteration, but new code should remain testable.
  - Future iterations may add other presentation layers, such as web and Android applications.
  - The current iteration is a monolithic Windows Forms application. Future iterations may move to a frontend-backend architecture exposed through APIs.

## Coding guidelines

- Preserve compatibility with .NET Framework 4.8.1 and the project's existing compiler/toolchain. Do not upgrade the target framework or project format unless asked.
- Do not add packages or projects without being explicitely asked to do so. Suggest it to developer if you think it is necessary or beneficial.
- Observe targeted instructions in [instructions directory](.github/instructions)
- When designing and naming new classes, methods, properties, and variables:
  - follow existing naming conventions and patterns in the solution
  - prefer conventions that would be compatibile with future implementing of Clean Architecture principles
  - prefer conventions that would be compatibile with future implementing of frontend-backend architecture
  - prefer conventions that would be compatibile with future implementing of adding other presentation layers, such as web and Android applications
  - if you find adding abstractions beneficial (for example - but not exclusively - in context of above preferences in this point), suggest it to developer and follow their decision

## Validation

- Build the solution or `ScheduleSync.Presentation.WinForms` project after making code changes.
- Run relevant tests when available. Do not claim tests were run if no test project or test runner is available.
- Suggest adding tests when necessary or beneficial, but do not add them without being explicitely asked to do so.

