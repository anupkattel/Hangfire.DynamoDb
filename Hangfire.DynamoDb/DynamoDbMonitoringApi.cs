using System;
using System.Collections.Generic;
using Hangfire.Storage;
using Hangfire.Storage.Monitoring;

namespace Hangfire.DynamoDb
{
    public class DynamoDbMonitoringApi : JobStorageMonitor
    {
        public override IList<QueueWithTopEnqueuedJobsDto> Queues()
        {
            throw new NotImplementedException();
        }

        public override IList<ServerDto> Servers()
        {
            throw new NotImplementedException();
        }

        public override JobDetailsDto JobDetails(string jobId)
        {
            throw new NotImplementedException();
        }

        public override StatisticsDto GetStatistics()
        {
            throw new NotImplementedException();
        }

        public override JobList<EnqueuedJobDto> EnqueuedJobs(string queue, int from, int perPage)
        {
            throw new NotImplementedException();
        }

        public override JobList<FetchedJobDto> FetchedJobs(string queue, int from, int perPage)
        {
            throw new NotImplementedException();
        }

        public override JobList<ProcessingJobDto> ProcessingJobs(int from, int count)
        {
            throw new NotImplementedException();
        }

        public override JobList<ScheduledJobDto> ScheduledJobs(int from, int count)
        {
            throw new NotImplementedException();
        }

        public override JobList<SucceededJobDto> SucceededJobs(int from, int count)
        {
            throw new NotImplementedException();
        }

        public override JobList<FailedJobDto> FailedJobs(int from, int count)
        {
            throw new NotImplementedException();
        }

        public override JobList<DeletedJobDto> DeletedJobs(int from, int count)
        {
            throw new NotImplementedException();
        }

        public override long ScheduledCount()
        {
            throw new NotImplementedException();
        }

        public override long EnqueuedCount(string queue)
        {
            throw new NotImplementedException();
        }

        public override long FetchedCount(string queue)
        {
            throw new NotImplementedException();
        }

        public override long FailedCount()
        {
            throw new NotImplementedException();
        }

        public override long ProcessingCount()
        {
            throw new NotImplementedException();
        }

        public override long SucceededListCount()
        {
            throw new NotImplementedException();
        }

        public override long DeletedListCount()
        {
            throw new NotImplementedException();
        }

        public override IDictionary<DateTime, long> SucceededByDatesCount()
        {
            throw new NotImplementedException();
        }

        public override IDictionary<DateTime, long> FailedByDatesCount()
        {
            throw new NotImplementedException();
        }

        public override IDictionary<DateTime, long> HourlySucceededJobs()
        {
            throw new NotImplementedException();
        }

        public override IDictionary<DateTime, long> HourlyFailedJobs()
        {
            throw new NotImplementedException();
        }
    }
}