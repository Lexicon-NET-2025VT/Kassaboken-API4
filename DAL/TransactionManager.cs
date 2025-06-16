namespace Kassaboken_API4.DAL
{
    public class TransactionManager
    {
        private static int dbSpeed = 1000;
        public static async Task<List<Models.Transaction>> GetAllTransactions()
        {
            if(DB.Transactions.Any() == false)
            {
                DB.Transactions.Add(new Models.Transaction()
                {
                    Title = "Lön",
                    Id = 1,
                    Amount = 32500.20M,
                    Date = DateTime.Now
                });
            }
            await Task.Delay(dbSpeed);
            return DB.Transactions;
        }

        public static async Task<Models.Transaction> GetTransaction(int id)
        {
            await Task.Delay(dbSpeed);
            return DB.Transactions.Where(t => t.Id == id).SingleOrDefault();
        }

        public static async Task CreateTransaction(Models.Transaction transaction)
        {
            transaction.Id = Random.Shared.Next(100, 1000);
            await Task.Delay(dbSpeed);
            DB.Transactions.Add(transaction);
            
        }

    }
}
