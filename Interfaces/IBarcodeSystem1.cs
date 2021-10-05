using System;
using System.Collections.Generic;
using OOPEXAM2020.Models;

namespace OOPEXAM2020
{
    public interface IBarcodeSystem1
    {
        List<Product> ActiveProducts { get; }
        List<User> ActiveUsers { get; }
        List<Transaction> AllTransactions { get; }

        InsertCashTransaction AddCreditsToAccount(User user, decimal amount);
        void BuyMultiProduct(User user, Product product, int quantity);
        BuyTransaction BuyProduct(User user, Product product);
        void ExecuteTransaction(Transaction transaction);
        Product GetProductByID(int productId);
        List<Transaction> GetTransactions(User user);
        User GetUserByID(string username);
        List<User> GetUsers(Func<User, bool> predicate);
    }
}