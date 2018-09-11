# NPS
V 0.0 (Intro)
Practice/warmup project using MVC to learn how to pull JSON data from the web and rehost it.
Data is of US National Parks from the NPS at: https://developer.nps.gov/api/v1/
(Note: API is inaccessible without a key)

V 0.1
Most pages are now functional, though "Explore" is barebones. More pages will be added eventually. "About" page also needs to be tweaked to have more information.

V 0.2
About page is more complete, and Exlpore page's functionality is improved. API call now receives full list of parks along with addresses. AutoCompleteModule implemented.

V 0.3
I found an error with the API. I can't make requests for operatingHours, images or contacts unless I severely limit the quantity of park datapoints I get - down to somewhere around 350. For now I'm just getting all 498 and not using the aforementioned data. Classes for images and operatingHours are written, though.

V 0.4
Need to flesh out details views from Explore, then V1 will be ready. Explore view is otherwise finished - along with Index, Directory and About (for now).