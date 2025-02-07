# Project Overview

This Blazor application mimics Salesforce's UI/UX, creating a dynamic Single Page Application (SPA) with tabs and navigation similar to Salesforce’s layout. The goal is to manage dynamic fragments that represent different pages within the app. Here’s how the system is structured:

## **MainLayout.razor**

`MainLayout.razor` is the central component of the SPA and is responsible for:

- Rendering the app’s **navigation sidebar**, which allows users to open different "fragments" (or "tabs").
- Displaying the **list of open tabs** within the main content area.
- Handling the **active tab** logic, updating the main content area based on user interaction:
  - When a user clicks on a tab in the sidebar, the corresponding tab content is displayed.
  - Users can also interact with the opened tabs list located at the top of the main content area to switch between active tabs.

## **Tab.razor**

`Tab.razor` works in conjunction with `MainLayout.razor` and represents an individual tab that displays dynamic content. It has the following responsibilities:

- Accepting a Razor component (e.g., `Counter.razor`, `Home.razor`, `Weather.razor`) to be rendered within the tab.
- Managing **tab-specific data** by accepting a key-value pair where:
  - **Key**: The type of the Razor component fragment.
  - **Value**: The corresponding JSON data (page data) to be displayed within the tab.

## **TabDataService.cs**

`TabDataService.cs` is the core service that handles the state and data for the tabs. It is responsible for:

- **Managing tab data**: Fetches the JSON data associated with each tab fragment.
- **Creating tab data**: Allows creation and storage of JSON data for each fragment.

This service ensures that each tab’s state and associated data are properly saved and retrieved as users interact with the app.
