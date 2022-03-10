# Weather Prediction Service

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

-  The purpose of my program is to generate and analyze a cvs and provide detailed information about weather in the Los Angles region. 


### 3a ii.

Describes what functionality of the program is demonstrated in the video.

- My program asks the user for an inputted and desired date. The program then generates a csv, matches all dates with the desired date. Then creates a prediction about the weather based of the desired the date. The prediction includes a mean, median, and mode. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

- My program accepts user inputted date from the keyboard, then The user enters a desired date and my program outputs a prediction dependent on the desired date. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp

            List<double> Mean = new List<double>();
            double allTemps = 0;
            foreach (double temp in toAnalyze) 
            {
                allTemps = temp + allTemps;


            }

            return allTemps / toAnalyze.Count;
        }
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
// TODO: Show a foreach loop accessing each element of the list from 3bi
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

- The list is stored in the variable Mean.

### 3b iv.

Describes what the data contained in the list represents in your program

- The list "mean" stores different extracted temperatures from the desired date. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

- My list contains an arbitrary amount of temperature from the extracted dates. If I was not able to manage the complexity of the program with a list, I would need to limit the amount of inputs into the program to avoid writing an unreasonable amount of if / else if statements that would only account for one temperature at a time. Similarly, i am able to perform very simple math when using a list of data to derive the "Mean"

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static double GetMean(List<double> toAnalyze)
        {
            if (toAnalyze == null ){
                throw new Exception ("Cannot analyze a null list");
            }
            List<double> Mean = new List<double>();
            double allTemps = 0;
            foreach (double temp in toAnalyze) 
            {
                allTemps = temp + allTemps;


            }

            return allTemps / toAnalyze.Count;
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
 double mean = KtoF(GetMean(FinalTemps));
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

- This method will take in the list of temperatures from the desired dates in the CSV which is called "toAnalyze". The method will then create a simple mathematic system that adds values to the double "allTemps". Then returns all temperatures in "allTemps" divided by the amount of temperatures in "toAnalyze". This method incorporates essential parts of basic programming to produce a prediction about the Mean that is displayed to the user in the final prediction

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

- GetMean is a simple method that beings by validating and ensuring that the list "toAnalyze" has content. It uses selection to ensure the program can move froward, if not, the program will throw an exception to the user and display an error message. The program then creates a list of doubles called "mean" and a double called AllTemps. AllTemps is then set to 0 to start the procedure. The program then iterates through each temperature within toAnalyze. The program then sets "allTemps" to the temperatures within toAnalyze + "alltemps". Thus updating the value of AllTemps. Finally, the program returns the double "allTemps" divided by the amount of temperatures that was in "toAnalyze."

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

- GetMean(null)

Second call:

- GetMean(List<double> toAnalyze)

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This test that the method will fail when the input is null by throwing an exception. 

Condition(s) tested by the second call:

This test that the method runs when the input is valid. 

### 3d iii.

Result of the first call:

The result is an exception is thrown 

Result of the second call:

The result is temperatures in the list toAnalyze. 