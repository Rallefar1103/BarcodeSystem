using System.Collections.Generic;
using OOPEXAM2020.Models;

namespace OOPEXAM2020
{
    public interface IBarcodeSystemUI1
    {
        bool Running { get; set; }

        void Close();
        void DidForgetSecondCommand();
        void DisplayAdminCommandNotFoundMessage();
        void DisplayGeneralError(string errorString);
        void DisplayInsufficientCash(User user, Product product);
        void DisplayLatestUserTransactions(User user, List<Transaction> transactions);
        void DisplayLowBalance();
        void DisplayProduct(Product product);
        void DisplayProductIsNotActive();
        void DisplayProductNotFound(string productName);
        void DisplayTooManyArgumentsError(string command);
        void DisplayUserBuysMultiProduct(Product boughtProduct, int quantity);
        void DisplayUserBuysProdct(BuyTransaction buyTransaction);
        void DisplayUserGetsCredits(string username, decimal amount);
        void DisplayUserInfo(User user);
        void DisplayUserLatestPurchases(List<Transaction> transactions);
        void DisplayUserNotFound(string username);
        void ProductIsNotInteger();
        void QuantityIsNotInteger();
        void RenderProductsMenu(List<Product> products);
        void Start();
    }
}