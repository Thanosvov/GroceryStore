// See https://aka.ms/new-console-template for more information


// Welcome user to the app
// Show available products to the user
// Show what is in the shopping car to the user
// Ask the user for what they want to buy
// IF the product the user wants to uy is available
// Put the product in the shopping cart
// Remove the product from available products
// ELSE
// Tell the user that the product is not available
// 

//List<string> warehouse = new();
//warehouse.Add("Old cheese");
//warehouse.Add("Stanky fish");
//warehouse.Add("Rotten tomato");
//warehouse.Add("Smelly egg");

//List<string> shoppingCart = new();
//List<string> userInventory = new();

//while(true)
//{ 
//    Console.Clear();
//    WelcomeMessage();

//    PrintWarehouse();
//    PrintShoppingcart();

//    string userInput = Console.ReadLine();
//    if (userInput == "cart")
//    {
//        PrintShoppingcart();
//    }
//    else if (IsProductAvailable(userInput))
//    {
//        MoveProductToShoppingCart(userInput);
//        Print("\n" + userInput + " was added to your cart.");
//    }
//    else if (IsProductInCart(userInput))
//    {
//        MoveProductFromShoppingCart(userInput);
//        Print("\n" + userInput + " was removed from your cart.");
//    }
//    else
//    {
//        Print("The product you are looking for doesn't exist...");
//    }

//    Console.WriteLine("\nPress enter to continue...");
//    Console.ReadLine();
//}

//// METHODS

//void PrintShoppingcart()
//{
//    if (shoppingCart.Count > 0)
//    {
//        Console.SetCursorPosition(0, 15);
//        Print("Here is your current shoppingcart:");
//        foreach (string item in shoppingCart)
//        {
//            Print(item);
//        }
//    }
//    else
//    {
//        Console.SetCursorPosition(0, 15);
//        Print("Your cart is empty...");
//    }
//    Console.WriteLine();
//}

//void MoveProductToShoppingCart(string product)
//{
//    warehouse.Remove(product);
//    shoppingCart.Add(product);
//}

//void MoveProductFromShoppingCart(string product)
//{
//    shoppingCart.Remove(product);
//    warehouse.Add(product);
//}

//bool IsProductAvailable(string product)
//{
//    foreach (string thing in warehouse)
//    {
//        if (thing == product)
//            return true;
//    }
//    return false;
//}

//bool IsProductInCart(string product)
//{
//    foreach (string thing in shoppingCart)
//    {
//        if (thing == product)
//            return true;
//    }
//    return false;
//}

//void PrintWarehouse()
//{
//    foreach (string ware in warehouse)
//    {
//        Console.WriteLine(" - " + ware);
//    }
//}

//void Print(string msg)
//{
//    Console.WriteLine(msg);
//}

//void WelcomeMessage()
//{
//    Print("Welcome to my Gross Store!");
//    Print("Enter 'cart' to view your shoppingcart, or 'Old cheese' to buy an old cheese.");
//    Print("Here's whats in the store:\n");
//}





// Övning 1

//string firstNumber = Console.ReadLine();
//string raknesatt = Console.ReadLine();
//string secondNumber = Console.ReadLine();
//int svar = 0;

//int firstConvert = Convert.ToInt32(firstNumber);
//int secondConvert = Convert.ToInt32(secondNumber);

//if (raknesatt == "+")
//{
//    svar = firstConvert + secondConvert;
//}
//else if (raknesatt == "-")
//{
//    svar = firstConvert - secondConvert;
//}

//Console.WriteLine(firstNumber + raknesatt + secondNumber + "=" + svar);