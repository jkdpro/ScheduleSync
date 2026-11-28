# Stop List Retrieving functionality

## General objective

Read and store locally the stop list from the Tristar API.

## Iteration 1

### Requirements

1.1 Create a simple testing window to display button "Pobierz przystanki" (English: "Retrieve stops") which would be accessible from the main form.
1.2 Create infrastructure code to retrieve the stop list from the Tristar API to relevant POCO model classes.
1.3 Provide a simple display of the retrieved stop list in the testing window, e.g. in a ListBox or DataGridView.

### Clarifications

#### Questions

- Q.1.1 [SOLVED] Should Iteration 1 keep the retrieved stops in memory only, with database persistence deferred? The general objective says to store the list locally, but the iteration requirements only specify retrieval into POCOs and display.
	- *Answer:* Yes. Keep the retrieved stops in memory only; defer database persistence to a later iteration.
- Q.1.2 [SOLVED] Which stop fields are required in the POCO and display, and should the API's complete stop list be retrieved without filtering?
	- *Answer:* Design POCOs to mirror the API response structure 1:1, with no filtering.
- Q.1.3 [SOLVED] Which Tristar endpoint and request details should be used, and are authentication, pagination, or query parameters required?
	- *Answer:* Derive the endpoint and request details from the API documentation, and verify against the API if useful. No authentication is required.
- Q.1.4 [SOLVED] Should the testing window be opened through a new button on the main form, or through another existing navigation control?
	- *Answer:* Add a new button to the main form; rename Form1 to MainForm.
- Q.1.5 [SOLVED] What behavior should users see while retrieval is in progress or when the API request fails?
	- *Answer:* Initially, show progress such as "Wysłano zapytanie do [URL]" and display responses, statuses, and errors in Polish in a memo or similar control. Refine the details through follow-up chat and code changes.
- Q.1.6 [OPEN] What is the correct unauthenticated request URL for retrieving the stops collection? The local PDF lists the GTFS stop fields but does not identify this request URL.

#### Remarks

- R.1.1 [SOLVED] The API resource index link has been corrected to point to the downloaded Tristar API PDF, as confirmed by the user.
- R.1.2 [OPEN] The provisional endpoint `https://api.zdiz.gdynia.pl/gtfs/stops` returned HTTP 401 to an unauthenticated GET during implementation, conflicting with the clarification that no authentication is required. Stop retrieval remains unverified until the correct public endpoint/access is confirmed.

## Iteration 2

TBD






