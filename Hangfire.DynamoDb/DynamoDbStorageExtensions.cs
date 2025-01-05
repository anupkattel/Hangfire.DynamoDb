using System;

namespace Hangfire.DynamoDb
{
    public static class DynamoDbBootstrapperConfigurationExtensions
    {
        public static DynamoDbStorage UseSqlServerStorage(
            this IGlobalConfiguration configuration,
            string nameOrConnectionString)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            if (nameOrConnectionString == null) throw new ArgumentNullException(nameof(nameOrConnectionString));

            var storage = new DynamoDbStorage();
            configuration.UseStorage(storage);

            return storage;
        }
    }
}
