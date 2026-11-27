---
applyTo: "**/*Form*.cs"
---

# Windows Forms guidance

- Keep designer-generated layout code in `*.Designer.cs`; make UI and behavior changes in the corresponding form code file where practical.
- Keep event handlers responsive. Use asynchronous APIs for operations that may take significant time, and avoid blocking the UI thread.
- Follow the repository’s existing project boundaries for shared logic. Keep logic independent of Windows Forms outside the presentation layer where the current architecture allows; don’t introduce new layers or abstractions solely for hypothetical future needs.
- Apply the repository’s general coding guidelines.