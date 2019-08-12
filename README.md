This project is focused on reading from a determined dataset and retrieving the latitude and longitude of cars in Israel. The dataset was downloaded from Kaggle but we only use 1,000 of the 6,000,000 entries it had. The program uses GMap.NET to interact with a map that uses Google Maps data. The user can choose to be a passanger or a driver. If he chooses passenger, he will then be able to see a window with the map and all the cars that are available. 

- If the user double clicks in a certain position on the map, the program will make a line from that position to the nearest car. 
- If the user hovers the mouse on the selected position or the nearest found car's marker, a label with the distance separating them will appear. If the user selects driver, he will only be able to select a point in the map by double clicking and add a car to the available list car. This causes the program to write on the .CSV file used as dataset.

It's a simple project, but the aim of it was primarily to try out the GMap.NET library and to read and write on a dataset.

The GMap.NET library turned out to be fairly easy to use and proved to be capable of a lot of functionalities.
