using backend.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace backend.Services
{
    public class CourseServices : ICourseServices
    {
       
        private readonly AzureCosmosDBSettings _azureCosmosDBSettings;
        public CourseServices(IOptions<AzureCosmosDBSettings> azureCosmosDBSettings)
        {
            _azureCosmosDBSettings = azureCosmosDBSettings.Value;
        }
        private Container ContainerClient()
        {
            CosmosClient cosmosDbClient = new CosmosClient(_azureCosmosDBSettings.URI, _azureCosmosDBSettings.PrimaryKey);
            Container containerClient = cosmosDbClient.GetContainer(_azureCosmosDBSettings.DatabaseName, _azureCosmosDBSettings.ContainerName);
            return containerClient;
        }
        public async Task<Courses> AddTask(Courses task)
        {
            var _container = ContainerClient();
            var item = await _container.CreateItemAsync<Courses>(task, new PartitionKey(task.id));
            return item;
        }
        public async Task DeleteTask(string id, string partition)
        {
            var _container = ContainerClient();
            await _container.DeleteItemAsync<Courses>(id, new PartitionKey(partition));
        }
        public async Task<List<Courses>> GetTasks(string cosmosQuery)
        {
            var _container = ContainerClient();
            var query = _container.GetItemQueryIterator<Courses>(new QueryDefinition(cosmosQuery));
            List<Courses> results = new List<Courses>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response);
            }
            return results;
        }
        public async Task<Courses> UpdateTask(Courses task)
        {
            var _container = ContainerClient();
            var item = await _container.UpsertItemAsync<Courses>(task, new PartitionKey(task.id));
            return item;
        }
    }
}

