# Weather Prediction Service Personal Project 
## Flowchart Layouts
### High level layout
![Image Text](HighLevelOV.png)
### Initial Question loop 
![Image Text](Iniital.png)
### Sting High level Flowchart
![Image Text](ListOV.png)

___________________________________________________

### Analyzing Getdate method
![Image Text](GetDateMethod.png)
- In this GetDate start method. There are w string created to house the date entered by the user. The user is then asked to give 2 separate integers that will represent the date. The month is expressed through an integer 1-12. The day is expressed through an integer 1-31. Then the user will see its confirmed date. Then, the method will execute a validation statement that makes sure the date exist in real life. For example, if the user entered dates like 02/31 or 06/97 then the statement would throw an exception and go back to the beginning of the document if the date is not valid. If the date is valid. The program will then move to the unfiltered list refereed to as list #1. 
#### P2 of Analyzing Getdate method
![Image Text](0.png)
- This second part of the method will loop through the first list and generate a second list based off the filtered dates dor list 1. List 1 will start full and List 2 will start empty and will be created after List 1 is looped thorough. Then after looping through list 2, a GetPrediction method will create predictions and print out the prediction of the Average, Mode, Mean, Median temps for that date to the user based off data from list 2. 


## Detailed Overview of New Method
![Image Text](GetMean.png)
- In this Method, the program will compute a mean off the filtered temperatures. The method begins by creating a double called "mean". Then the double "allTemps" will be sent to 0. Then using a foreach loop that runs through all temps in to analyze will set AllTemps to the total temperature of all the temps. Then the method will return the final temperature divided by the amount of temps in Toanalyzed. 


## HighLevel Overview of CreatePred
![Image Text](CreatePred.png)
- In this method, in order to create a prediction the csv will be loaded and put into the method. Then the method will use GetStarted to get a date from the user. Then validate date will ensure the date works and can be read by the program. User date will then be matched with dates in the CVS using Filterdates. Then GetTemperature will draw out the temps from the filtered dates. With all the temperatures, GetMean, GetMode, and GetMedian will calculate and create a prediction. 

