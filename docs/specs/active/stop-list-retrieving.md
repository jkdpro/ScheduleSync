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

- Q.1.1 Should Iteration 1 keep the retrieved stops in memory only, with database persistence deferred? The general objective says to store the list locally, but the iteration requirements only specify retrieval into POCOs and display.
- Q.1.2 Which stop fields are required in the POCO and display (for example, stop ID, name, and coordinates), and should the API's complete stop list be retrieved without filtering?
- Q.1.3 Which Tristar endpoint and request details should be used, and are authentication, pagination, or query parameters required?
- Q.1.4 Should the testing window be opened through a new button on the main form, or through another existing navigation control?
- Q.1.5 What behavior should users see while retrieval is in progress or when the API request fails?

#### Remarks

- R.1.1 [SOLVED] The API resource index link has been corrected to point to the downloaded Tristar API PDF, as confirmed by the user.

## Iteration 2

TBD






