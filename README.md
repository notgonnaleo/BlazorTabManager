Copying salesforce UI/UX but for a blazor app, doing in the worst way possible maybe?
I'm not sure if this is a good idea, but I'm going to try it anyway.

* MainLayout.razor
- Is the main component of the SPA (Single Page Application) where we are going to render different page components fragments.
- It has the responsabilities of:
1. Render the app navigation sidebar which will let the user open a fragment aka "new tab"
2. Show the list of open tabs (fragments) in the main content area
3. Set the active tab (fragment) to be rendered in the main content area, when the user clicks on a tab in the sidebar or at any
already opened tab at the upper part of the main content area. (Opened tabs list)

* Tab.razor
- Basically is coupled with MainLayout, being the fragment that will be used as the mirror for rendering other components.
- It has the responsabilities of:
1. Receive a razor component to be rendered as a tab content (Counter.razor, Home.razor, Weather.razor)
2. Receive the razor component data to be rendered together with the actual component fragment being a key and value pair, 
"Type" (for the component fragment) and "object" (for the JSON data which is the "page" data at the moment)

* TabDataService.cs
- It's the tab state and data management core, we are going to save and read the JSON data that were created and used inside
the respective component being mirrored at the Tab.razor component.
- It has the responsabilities of:
1. Get pages fragment JSON/object data
2. Create pages fragment JSON/object data