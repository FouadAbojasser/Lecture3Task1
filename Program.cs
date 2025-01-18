namespace Lecture3Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "";
            List<int> myList = new List<int>() {4,5,5,5,5,5,5,5,5,5,5};
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("======== Welcome to Task No. 2 ========");
            Console.ResetColor();
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------------------");

            while (userChoice != "q")
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("P - Print list numbers");
                Console.WriteLine("A - Add single or multiple numbers");
                Console.WriteLine("M - Find Mean value of the numbers in the list");
                Console.WriteLine("S - Find the smallest number in the list");
                Console.WriteLine("L - Find the largest number in the list");
                Console.WriteLine();
                Console.WriteLine("SRT - Sort list numbers in ascending or descending order");
                Console.WriteLine("RMV - Remove specific number or remove dublications from the list");
                Console.WriteLine("SCH - Search for specific number in the list");
                Console.WriteLine("CLN - Clean the list numbers");

                Console.WriteLine("------------");
                Console.WriteLine("Q - Quit the task");
                Console.WriteLine();

                Console.Write("Enter Your Choice: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                userChoice = Console.ReadLine().ToLower().Trim();
                Console.ResetColor();
                Console.WriteLine();

                switch (userChoice)
                {
                    case "p":
                        if (myList.Count > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            // ===== Printing the List
                            Console.Write("Your Current List = [ ");
                            for (int i = 0; i < myList.Count; i++)
                            {
                                Console.Write(myList[i]);
                                if (i < myList.Count - 1)
                                    Console.Write(" , ");
                            }
                            Console.Write(" ]");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.WriteLine();
                            // ====================
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" [] - The List is empty !!");
                            Console.ResetColor();
                            Console.WriteLine();

                        }
                        break;



                    case "m":
                        if (myList.Count > 0)
                        {
                            int sumOfElements = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            // ===== Printing the List ===========
                            Console.Write("Your Current List = [");
                            for (int i = 0; i < myList.Count; i++)
                            {
                                Console.Write(myList[i]);
                                if (i < myList.Count - 1)
                                    Console.Write(" , ");
                            }
                            Console.Write(']');
                            Console.WriteLine();
                            // =================================
                            for (int i = 0; i < myList.Count; i++)
                            {
                                sumOfElements += myList[i];
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Mean Value of the List = {sumOfElements / myList.Count}");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            // ===== Printing the List ===========
                            Console.Write("Your Current List = [");
                            for (int i = 0; i < myList.Count; i++)
                            {
                                Console.Write(myList[i]);
                                if (i < myList.Count - 1)
                                    Console.Write(" , ");
                            }
                            Console.Write(']');
                            Console.WriteLine();
                            // =================================
                            Console.WriteLine();
                            Console.WriteLine("Cound not calculate mean value for empty list !!");
                            Console.ResetColor();
                            Console.WriteLine();

                        }
                        break;




                    case "l":
                        if (myList.Count > 0)
                        {
                            int sumOfElements = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            // ===== Printing the List ===========
                            Console.Write("Your Current List = [");
                            for (int i = 0; i < myList.Count; i++)
                            {
                                Console.Write(myList[i]);
                                if (i < myList.Count - 1)
                                    Console.Write(" , ");
                            }
                            Console.Write(']');
                            Console.WriteLine();
                            // =================================
                            int largestValue = myList[0];
                            for (int i = 0; i < myList.Count; i++)
                            {
                                if (myList[i] > largestValue)
                                {
                                    largestValue = myList[i];
                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Largest Value in the list = {largestValue}");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            // ===== Printing the List ===========
                            Console.Write("Your Current List = [");
                            for (int i = 0; i < myList.Count; i++)
                            {
                                Console.Write(myList[i]);
                                if (i < myList.Count - 1)
                                    Console.Write(" , ");
                            }
                            Console.Write(']');
                            Console.WriteLine();
                            // =================================
                            Console.WriteLine();
                            Console.WriteLine("Largest Value Could not be found in an empty list !!");
                            Console.ResetColor();
                            Console.WriteLine();

                        }
                        break;




                    case "s":
                        if (myList.Count > 0)
                        {
                            int sumOfElements = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            // ===== Printing the List ===========
                            Console.Write("Your Current List = [");
                            for (int i = 0; i < myList.Count; i++)
                            {
                                Console.Write(myList[i]);
                                if (i < myList.Count - 1)
                                    Console.Write(" , ");
                            }
                            Console.Write(']');
                            Console.WriteLine();
                            // =================================
                            int smallesttValue = myList[0];
                            for (int i = 0; i < myList.Count; i++)
                            {
                                if (myList[i] < smallesttValue)
                                {
                                    smallesttValue = myList[i];
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine($"Smallest Value in the list = {smallesttValue}");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            // ===== Printing the List ===========
                            Console.Write("Your Current List = [");
                            for (int i = 0; i < myList.Count; i++)
                            {
                                Console.Write(myList[i]);
                                if (i < myList.Count - 1)
                                    Console.Write(" , ");
                            }
                            Console.Write(']');
                            Console.WriteLine();
                            // =================================
                            Console.WriteLine();
                            Console.WriteLine("Smallest Value Could not be found in an empty list !!");
                            Console.ResetColor();
                            Console.WriteLine();

                        }
                        break;




                    case "a":
                        char typeOfAdd = ' ';
                        Console.WriteLine("Please select type of Adding new element(s) to the List ...".PadLeft(10+ "Please select type of Adding new element(s) to the List ...".Length));
                        Console.WriteLine("--------".PadLeft(10+ "--------".Length));
                        Console.WriteLine("S - Single Value".PadLeft(10+ "S - Single Value".Length));
                        Console.WriteLine("M - Multiple Values".PadLeft(10+ "M - Multiple Values".Length));
                        int currentLine = Console.CursorTop;
                        Console.SetCursorPosition(10, currentLine + 1); // 10th column, 1 line below the current position
                        Console.Write("Enter your choice: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        typeOfAdd = Convert.ToChar(Console.ReadLine().ToLower().Trim());
                        Console.ResetColor();

                        switch (typeOfAdd)
                        {
                            case 's':
                                Console.Write("Please enter the value ... ".PadLeft(10+ "Please enter the value ... ".Length));
                                Console.ForegroundColor = ConsoleColor.Blue;
                                int valueToBeAdded = Convert.ToInt32(Console.ReadLine());
                                Console.ResetColor();
                                Console.WriteLine();

                                // ======== checked for dublication =====
                                bool foundInTheList = false;
                                int indexOfFirstFound = 0;
                                for (int i = 0; i < myList.Count; i++)
                                {
                                    if (valueToBeAdded == myList[i])
                                    {
                                        foundInTheList = true;
                                        indexOfFirstFound = i;
                                        break;
                                    }
                                }
                                // =====================

                                if (foundInTheList)
                                {
                                    Console.WriteLine($"{valueToBeAdded} is already exisit in the list at index = {indexOfFirstFound}".PadLeft(13 + " is already exisit in the list at index = ".Length));
                                    Console.WriteLine();
                                    Console.Write("Would you like to allow dublication? (y) for Yes (n) for No: ".PadLeft(11 + "Would you like to allow dublication? (y) for Yes (n) for No ".Length));
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    char allowDublicationChoice = Convert.ToChar(Console.ReadLine().ToLower().Trim());
                                    if (allowDublicationChoice == 'y')
                                    {
                                        myList.Add(valueToBeAdded);
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"{valueToBeAdded} has been Added Successfully !!");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (allowDublicationChoice == 'n')
                                    {
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"{valueToBeAdded} has not been Added !!");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid enter !!".PadLeft(11+ "Invalid enter !!".Length));
                                        Console.ResetColor();
                                        Console.WriteLine();
                                        break;
                                    }

                                }
                                else
                                {
                                    myList.Add(valueToBeAdded);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{valueToBeAdded} has been Added Successfully !!");
                                    Console.ResetColor();
                                }

                                break;


                            case 'm':
                                Console.Write("Please enter a comma seperated values: x,y,z ... ".PadLeft(10+ "Please enter a comma seperated values: x,y,z ... ".Length));
                                Console.ForegroundColor = ConsoleColor.Blue;
                                string[] StringValuesToBeAdded = (Console.ReadLine().Split(','));
                                Console.ResetColor();
                                Console.WriteLine();

                                for (int i = 0; i < StringValuesToBeAdded.Count(); i++)

                                    {
                                        //Console.WriteLine((StringValueToBeAdded[i]));
                                        int SingleExtractedValue = Convert.ToInt32(StringValuesToBeAdded[i].ToString());
                                        //int cuttedvalue = StringValueToBeAdded[i] - '0';

                                        // ======== checked for dublication =====
                                        foundInTheList = false;
                                        indexOfFirstFound = 0;
                                        for (int x = 0; x < myList.Count; x++)
                                        {
                                            if (SingleExtractedValue == myList[x])
                                            {
                                                foundInTheList = true;
                                                indexOfFirstFound = x;
                                                break;
                                            }
                                        }
                                    // =====================

                                    if (foundInTheList)
                                    {
                                        Console.WriteLine($"{SingleExtractedValue} is already exisit in the list at index = {indexOfFirstFound}".PadLeft(13 + "is already exisit in the list at index = ".Length));
                                        Console.WriteLine();
                                        Console.Write("Would you like to allow dublication? (y) for Yes (n) for No: ".PadLeft(11 + "Would you like to allow dublication? (y) for Yes (n) for No ".Length));
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        char allowDublicationChoice = Convert.ToChar(Console.ReadLine().ToLower().Trim());
                                        if (allowDublicationChoice == 'y')
                                        {
                                            myList.Add(SingleExtractedValue);
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine($"{SingleExtractedValue} has been Added Successfully !!".PadLeft(12 + "has been Added Successfully !!".Length));
                                            Console.ResetColor();
                                            Console.WriteLine();

                                        }
                                        else if (allowDublicationChoice == 'n')
                                        {
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"{SingleExtractedValue} has not been Added !!".PadLeft(12 + " has not been Added !!".Length));
                                            Console.ResetColor();
                                            Console.WriteLine();

                                        }
                                        else
                                        {
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Invalid enter !!".PadLeft(11 + "Invalid enter !!".Length));
                                            Console.ResetColor();
                                            Console.WriteLine();

                                        }

                                    }
                                    else
                                    {
                                        myList.Add(SingleExtractedValue);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"{SingleExtractedValue} has been Added Successfully !!".PadLeft(12 + " has been Added Successfully !!".Length));
                                        Console.ResetColor();
                                    }
                                }
                            
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your input list has been proccessed as per your choice successfully !!");
                                Console.ResetColor();
                                Console.WriteLine();
                                break;

                            default:
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input !!".PadLeft(10+ "Invalid Input !!".Length));
                                Console.ResetColor();
                                Console.WriteLine();
                                break;

                        }
                        break;

                    case "srt":
                        char typeOfSort = ' ';
                        Console.WriteLine("Please select type of Sorting new element(s) inside the List ...".PadLeft(10 + "Please select type of Sorting new element(s) inside the List ...".Length));
                        Console.WriteLine("--------".PadLeft(10 + "--------".Length));
                        Console.WriteLine("A - Ascending Order".PadLeft(10 + "A - Ascending Order".Length));
                        Console.WriteLine("D - Descending Order".PadLeft(10 + "D - Descending Order".Length));
                        currentLine = Console.CursorTop;
                        Console.SetCursorPosition(10, currentLine + 1); // 10th column, 1 line below the current position
                        Console.Write("Enter your choice: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        typeOfSort = Convert.ToChar(Console.ReadLine().ToLower().Trim());
                        Console.ResetColor();
                        switch (typeOfSort)
                        {

                            case 'a':

                                List<int> sortedList = new List<int>() { };
                                while (myList.Count > 0)
                                {
                                    int smallestValue = myList[0];
                                    for (int i = 0; i < myList.Count; i++)
                                    {
                                        if (myList[i] < smallestValue)
                                        {
                                            smallestValue = myList[i];
                                        }
                                    }
                                    sortedList.Add(smallestValue);
                                    myList.Remove(smallestValue);
                                }
                                myList = sortedList;
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                // ===== Printing the List ===========
                                Console.Write("Your Ascending Sorted List = [ ");
                                for (int i = 0; i < myList.Count; i++)
                                {
                                    Console.Write(myList[i]);
                                    if (i < myList.Count - 1)
                                        Console.Write(" , ");
                                }
                                Console.Write(" ]");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.WriteLine();
                                // =================================
                                break;



                            case 'd':
                                sortedList = new List<int>() { };
                                while (myList.Count > 0)
                                {
                                    int largestValue = myList[0];
                                    for (int i = 0; i < myList.Count; i++)
                                    {
                                        if (myList[i] > largestValue)
                                        {
                                            largestValue = myList[i];
                                        }
                                    }
                                    sortedList.Add(largestValue);
                                    myList.Remove(largestValue);
                                }
                                myList= sortedList;
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                // ===== Printing the List ===========
                                Console.Write("Your Descending Sorted List = [ ");
                                for (int i = 0; i < myList.Count; i++)
                                {
                                    Console.Write(myList[i]);
                                    if (i < myList.Count - 1)
                                        Console.Write(" , ");
                                }
                                Console.Write(" ]");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.WriteLine();
                                // =================================
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.WriteLine("Invalid Input !!".PadLeft(10+ "Invalid Input !!".Length));
                                Console.ResetColor();
                                Console.WriteLine();
                                break;

                        }
                        break;


                    case "rmv":
                        char typeOfRemove = ' ';
                        Console.WriteLine("Please select how to remove element(s) from the List ...".PadLeft(10 + "Please select how to remove element(s) from the List ...".Length));
                        Console.WriteLine("--------".PadLeft(10 + "--------".Length));
                        Console.WriteLine("D - Remove dublicated elements".PadLeft(10 + "D - Remove dublicated elements".Length));
                        Console.WriteLine("S - Remove selected elements".PadLeft(10 + "S - Remove selected elements".Length));
                        currentLine = Console.CursorTop;
                        Console.SetCursorPosition(10, currentLine + 1); // 10th column, 1 line below the current position
                        Console.Write("Enter your choice: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        typeOfRemove = Convert.ToChar(Console.ReadLine().ToLower().Trim());
                        Console.ResetColor();

                        switch (typeOfRemove)
                        {
                            case 's':
                                currentLine = Console.CursorTop;
                                Console.SetCursorPosition(10, currentLine + 1); // 10th column, 1 line below the current position
                                Console.Write("Enter the value to be removed from the list: ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                int valueTobeRemoved = Convert.ToInt32(Console.ReadLine().ToLower().Trim());
                                Console.ResetColor();
                                // check if the value exists in the list
                                 bool foundInTheList = false;
                                for (int i = 0;i<myList.Count;i++)
                                {
                                    if (myList[i] == valueTobeRemoved)
                                    {
                                        foundInTheList = true;
                                        myList.Remove(valueTobeRemoved);
                                        i = 0;
                                    }
                                   
                                }
                                // ===== Printing the The Resulted List ===========
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                if (foundInTheList)
                                    Console.Write($"Your list after removing {valueTobeRemoved}  = [ ".PadLeft(13 + "Your list after removing = [ ".Length));
                                else
                                {
                                    Console.WriteLine($"The value {valueTobeRemoved} does not exist in the list".PadLeft(12 + "The value does not exist in the list ".Length));
                                    Console.WriteLine();
                                    Console.Write($"Your list has no changes  = [ ".PadLeft(11 + "Your list has no changes  = [ ".Length));
                                }
                                for (int i = 0; i < myList.Count; i++)
                                {
                                    Console.Write(myList[i]);
                                    if (i < myList.Count - 1)
                                        Console.Write(" , ");
                                }
                                Console.Write(" ]");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.WriteLine();


                                break;



                            case 'd':
                                int selectedValue;
                                int x = 0;
                                List<int> dublicatedValuesList = new List<int>();
                                List<int> dublicatedValuesList2 = new List<int>();
                                while (x < myList.Count)
                                {
                                    selectedValue = myList[x];
                                    for (int i = 1 + x; i < myList.Count; i++)
                                    {
                                        if (selectedValue == myList[i])
                                        {
                                           
                                            // ======== checked for dublication in dublicatedValuesList =====
                                            foundInTheList = false;
                                            for (int j = 0; j < dublicatedValuesList.Count; j++)
                                            {
                                                if (dublicatedValuesList[j] == selectedValue)
                                                {
                                                    foundInTheList = true;
                                                    break;
                                                }
                                            }
                                            if (!foundInTheList)
                                                dublicatedValuesList.Add(selectedValue);
                                            // =================================================================
                                        }
                                        
                                    }
                                    x++;
                                }
                                // == Remove dublicated values
                                int y = 0;
                                while (y < dublicatedValuesList.Count)
                                {
                                    for (int z = 0; z < myList.Count; z++)
                                        if (myList[z] == dublicatedValuesList[y])
                                        {
                                            myList.Remove(dublicatedValuesList[y]);
                                            z = 0;
                                        }
                                    y++;
                                }
                                // == adding them back for one time
                                for (int k = 0; k < dublicatedValuesList.Count; k++)
                                    myList.Add(dublicatedValuesList[k]);


                                // ===== Printing the dublicatedValuesList ===========
                                Console.WriteLine();
                                Console.ForegroundColor= ConsoleColor.Green;
                                Console.Write("Your dublicated values = [ ".PadLeft(10+ "Your dublicated values = [ ".Length));
                                for (int i = 0; i < dublicatedValuesList.Count; i++)
                                {
                                    Console.Write(dublicatedValuesList[i]);
                                    if (i < dublicatedValuesList.Count - 1)
                                        Console.Write(" , ");
                                }
                                Console.Write(" ]");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.WriteLine();

                                // ===== Printing the The Resulted List ===========
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Your list after removing dublications  = [ ".PadLeft(10 + "Your list after removing dublications  = [ ".Length));
                                for (int i = 0; i < myList.Count; i++)
                                {
                                    Console.Write(myList[i]);
                                    if (i < myList.Count - 1)
                                        Console.Write(" , ");
                                }
                                Console.Write(" ]");
                                Console.WriteLine();
                                Console.ResetColor();
                                Console.WriteLine();

                                break;
                        }
                        break;



                    case "sch":
                        Console.Write("Enter value to search for: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.ResetColor();
                        int valueToSearchFor = Convert.ToInt32(Console.ReadLine());
                        bool searchfoundInTheList = false;
                        List<int> indexes = new List<int>();
 
                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (myList[i] == valueToSearchFor)
                            {
                                searchfoundInTheList = true;
                                indexes.Add(i);
                            }

                        }
                        // ===== Printing the The Resulted List ===========
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (searchfoundInTheList)
                        {
                            Console.Write($"The value {valueToSearchFor} has been found at indexes  = [ ");
                            for (int i = 0; i < indexes.Count; i++)
                            {
                                Console.Write(indexes[i]);
                                if (i < indexes.Count - 1)
                                    Console.Write(" , ");
                            }
                            Console.Write(" ]");
                            Console.WriteLine();
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The value {valueToSearchFor} does not exist in the list");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        break;


                    case "cln":
                        myList.Clear();
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Your list has been cleaned successfully !! ->  [ ]");
                            Console.ResetColor();
                            Console.WriteLine();

                        }
                        
                        break;







                    case "q":
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" Thank You .. Goodbye !!");
                            Console.ResetColor();
                            Console.WriteLine();
                            break;
                        }

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input !!");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                }



            }

















        }
    }
}
