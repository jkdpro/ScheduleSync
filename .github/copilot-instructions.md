# Repository instructions

## Business context

- The solution is to provide a Windows Forms application for:
  - getting publicly available public transport schedules and traffic info via API calls,
  - storing received data in a database,
  - displaying data in a user-friendly way.
- The current iteration is a self-training solution. The main exercise areas are Windows Forms, C# asynchronous programming, API calls, and Entity Framework.

## Technical context

- The solution currently has two projects:
  - `ScheduleSync.Presentation.WinForms` - the Windows Forms presentation project, targeting .NET Framework 4.8.1.
  - `ScheduleSync.Infrastructure` - intended for code that does not depend on Windows Forms, including business logic, data access, and API integration.
- During current development, use Microsoft SQL Server for persistence and Entity Framework 6.x (EF6) with the Code First approach for data access. These are current development requirements, not future possibilities.
- Public API details will be provided later with the relevant feature requirements.

## Roadmap and assumptions

- The current iteration is planned as a monolithic Windows Forms application. When implementation begins, the WinForms project is expected to use Infrastructure directly; do not assume application behavior or integrations already exist just because the projects are present.
- Keep new code testable and favor separation of concerns in line with Clean Architecture principles, without assuming that those architectural layers have already been implemented.
- Future iterations may split Infrastructure into separate projects, add other presentation layers (such as web or Android), or expose backend functionality through APIs. Treat these as possible future directions, not current implementation requirements.

## Coding guidelines

- Preserve compatibility with .NET Framework 4.8.1 and the project's existing compiler/toolchain. Do not upgrade the target framework or project format unless asked.
- Do not add packages or projects unless explicitly requested. If one seems necessary or beneficial, explain why and ask the developer before adding it.
- Follow any applicable instructions in `.github/instructions`.
- Follow existing naming conventions and patterns. Keep new code testable and loosely coupled where practical, but do not add abstractions solely for hypothetical future architecture.

## Specification workflow

- Store feature specifications as Markdown files under `docs/specs/`.
- Keep specifications that are currently being processed or are queued in `docs/specs/active/`.
- Move completed or cancelled specifications to `docs/specs/closed/` as an archive.
- When working on a feature, consult its specification in `active/`. Treat specifications in `closed/` as historical unless asked otherwise.

## Validation

- Build the solution or `ScheduleSync.Presentation.WinForms` project after making code changes.
- Run relevant tests when available. Do not claim tests were run if no test project or test runner is available.
- Suggest tests when they would be beneficial, but do not add them unless requested.

