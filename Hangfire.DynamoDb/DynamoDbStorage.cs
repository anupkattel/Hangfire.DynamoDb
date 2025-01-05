using System;
using Hangfire.Storage;

namespace Hangfire.DynamoDb
{
    public class DynamoDbStorage : JobStorage
    {
        public override IMonitoringApi GetMonitoringApi()
        {
            return new DynamoDbMonitoringApi();
        }

        public override IStorageConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}