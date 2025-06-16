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


    }
}
