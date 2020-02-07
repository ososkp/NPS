# NPS

Intro

Practice/warmup project using MVC to learn how to pull JSON data from the web and rehost it.
Data is of US National Parks from the NPS at: https://developer.nps.gov/api/v1/
(Note: API is inaccessible without a key)


Change Log

V 0.1
Most pages are now functional, though "Explore" is barebones. More pages will be added eventually. "About" page also needs to be tweaked to have more information.

V 0.2
About page is more complete, and Exlpore page's functionality is improved. API call now receives full list of parks along with addresses. AutoCompleteModule implemented.

V 0.3
I found an error with the API. I can't make requests for operatingHours, images or contacts unless I severely limit the quantity of park datapoints I get - down to somewhere around 350. For now I'm just getting all 498 and not using the aforementioned data. Classes for images and operatingHours are written, though.

V 0.4
Need to flesh out details views from Explore, then V1 will be ready. Explore view is otherwise finished - along with Index, Directory and About (for now).

V 0.5
Details view in Explore is now the same as the one in Directory - not the final version, as it will be tailored to show what the user wants as a potential visitor, but good enough for version 1. Still no implementation of the Visitor Info button.

V 1
All pages have content and are at least mostly finished and working. Other than the Visitor Info button in Explore, everything exists as the barebones version of what this app will be. More will be added and aesthetic changes will be made later.

V 1.1
Explore page now looks better and is more functional - Visitor Information button shows details not included in Directory's details view.

V1.2
Now works on Azure web app hosting - but can't read from .json and throws a filenotfound exception. Need to migrate to an SQL database on Azure I think.

V2.0
Project is now live on Azure with full functionality.

V2.1
Removed "Refresh Parks List" button. There is a dataset error in the NPS API that is causing me to be unable to pull data after entry number 382. Before, I could pull up to 498 without error. Rather than shrink the data when a user hits refresh and overwrites the .json file, I'm just getting rid of the button until the issue is fixed.
Note: I've tried contacting the NPS dev team about this with no luck.

V2.2
Removed ability to navigate to the 'About' page from the navbar. Need to figure out how to fix the styling issues that have
suddenly popped up.