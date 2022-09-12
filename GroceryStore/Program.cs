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


string[] warehouse =
{
    "old cheese",
    "stanky fish"
};
string[] shoppingCart =
{

};
string[] userInventory = {
    
};

Print("Welcome to my Gross Store!");
Print("Here's whats in the store: ");

PrintWarehouse();

string userInput = Console.ReadLine();

if (IsProductAvailable(userInput))
{
    PutProductInShoppingCart(userInput);
}
else
{
    Print("The product you are looking for doesn't exist...");
}


// METHODS

void PutProductInShoppingCart(string product)
{

}

bool IsProductAvailable(string product)
{
    foreach (string thing in warehouse)
    {
        if (thing == product)
            return true;
    }
    return false;
}

void PrintWarehouse()
{
    foreach (string ware in warehouse)
    {
        Console.WriteLine(" - " + ware);
    }
}

void Print(string msg)
{
    Console.WriteLine(msg);
}