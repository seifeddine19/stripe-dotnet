﻿namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeScheduledQueryService : StripeBasicService<StripeScheduledQueryRun>
    {
        public StripeScheduledQueryService()
            : base(null)
        {
        }

        public StripeScheduledQueryService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeScheduledQueryRun Get(string queryRunId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntity($"{Urls.BaseUrl}/sigma/scheduled_query_runs/{queryRunId}", requestOptions);
        }

        public virtual StripeList<StripeScheduledQueryRun> List(StripeScheduledQueryListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityList($"{Urls.BaseUrl}/sigma/scheduled_query_runs", requestOptions, listOptions);
        }

        public virtual Task<StripeScheduledQueryRun> GetAsync(string queryRunId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/sigma/scheduled_query_runs/{queryRunId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeScheduledQueryRun>> ListAsync(StripeScheduledQueryListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/sigma/scheduled_query_runs", requestOptions, cancellationToken, listOptions);
        }
    }
}