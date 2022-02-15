# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

- The purpose of my program is to generate and analyze a cvs and provide detailed information about weather in the Los Angles region. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

- My program generates a CSV file and provides information about that file.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

- My program accepts user input from the keyboard. The user enters a desired date and my program outputs their desired date with the amount of dates in te CSV files generated. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
  List<string> results = new List<string>();

                foreach (string line in data)
                {
                    List<string> row = line.Split(",").ToList();
                    string yearMonthDay = row[1];
                    string rowMonth = yearMonthDay.Substring(5, 2);
                    string rowDay = yearMonthDay.Substring(8, 2);

                    if (rowDay == day && rowMonth == month)
                    {
                        results.Add(line);
                    }

```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
// Ok because this project is super hard and taking a fun long time, i haven't implemented this string in a different method. I will use the List "Results" in GetTemperatures and extract the desired temperatures out all the lines in "results"
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

- The list is stored in the variable "results". 

### 3b iv.

Describes what the data contained in the list represents in your program

 - This list represents each line of data from the CSV that matches the desired date from the user input. 

### 3b v.

- My list contains an arbitrary amount of dates/lines of data. If I was not able to manage the complexity of the program with a list, I would need to limit the amount of inputs into the program to avoid writing an unreasonable amount of if / else if statements that would only be one date., Using the list, i efficiently search and pull the desired data out of a large list. 

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
 public static List<string> FilterDates(List<string> data, string month, string day)
        {
            int MonthNum;
            if(int.TryParse(month, out MonthNum) == false || month.Length != 2 || MonthNum >= 13)
            {
                throw new Exception($" Cannot use invalid {month}");
            }
            
            int dayNum;
            if(int.TryParse(day, out dayNum) == false)
            {
                throw new Exception($"Cannot use invalid date {day}");
            }
            // List<string> first_line_data = data[1].Split(",").ToList();
            // string date = first_line_data[1]; 
            List<string> results = new List<string>();

            foreach(string line in data)
            {
                List<string> row = line.Split(",").ToList();
                string yearMonthDay = row[1];
                string rowMonth = yearMonthDay.Substring(5,2);
                string rowDay = yearMonthDay.Substring(8,2);

                if (rowDay==day && rowMonth==month)
                {
                    results.Add(line);
                }


            }
            return results;
        }

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
FilterDates( List<string> data, string month, string day);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

- This Method will will filter and match the UserMonth and UserDay to the dates from the CVS. It will return a string of dates that matched the users dates. This is the main part of the program which will match user input with the correct dates of the CSV

### 3c iv.    ***** TO DO FOR HW ****

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

FilterDates(null)

Second call:

FilterDates (List<string> data, string month, string day)

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This test that the method will fail when the input is null by throwing an exception. 

Condition(s) tested by the second call:

This test that the mehtod runs when the input is valid. 

### 3d iii.

Result of the first call:

The result is an exception is thrown 

Result of the second call:

The result is the filtered dates in the list results. 