using Microsoft.AspNetCore.Mvc;

namespace Kassaboken_API4.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        [HttpGet]
        public async Task<List<Models.Transaction>> GetAllTransactionsABC()
        {
           return await DAL.TransactionManager.GetAllTransactions();
        }

        [HttpGet("{id}")]
        public async Task<Models.Transaction> GetTransaction(int id)
        {
            return await DAL.TransactionManager.GetTransaction(id);
        }


        [HttpPost]
        public async Task PostTransaction([FromBody] Models.Transaction transaction)
        {
            await DAL.TransactionManager.CreateTransaction(transaction);
        }

        [HttpPut("{id}")]
        public async Task PutTransaction(int id, [FromBody] Models.Transaction transaction)
        { 
            await DAL.TransactionManager.UpdateTransaction(id, transaction);
        }

        [HttpDelete("{id}")]
        public async Task DeleteTransaction(int id)
        {
            await DAL.TransactionManager.DeleteTransaction(id);
        }

    }
}
