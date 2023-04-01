using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DemoCenter.Web.Models.Configurations;
using Microsoft.Extensions.Configuration;
using RESTFulSense.Clients;

namespace DemoCenter.Web.Brokers.ApiBrokers
{
    public partial class ApiBroker : IApiBroker
    {
        private HttpClient httpClient;
        private readonly IConfiguration configuration;
        private readonly IRESTFulApiFactoryClient apiClient;

        public ApiBroker(HttpClient httpClient,
            IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;
            this.apiClient=GetApiClient(configuration);
        }

        private async ValueTask<T> GetAsync<T>(string relativeUrl) =>
            await this.apiClient.GetContentAsync<T>(relativeUrl);   

        private async ValueTask<T> PostAsync<T>(string relativeUrl, T content) =>
            await this.apiClient.PostContentAsync<T>(relativeUrl, content);

        private async ValueTask<T> PutAsync<T>(string relativeUrl, T content) =>
         await this.apiClient.PutContentAsync<T>(relativeUrl, content);

        private async ValueTask<T> DeleteAsync<T>(string relativeUrl) =>
            await this.apiClient.DeleteContentAsync<T>(relativeUrl);


        private RESTFulApiFactoryClient GetApiClient(IConfiguration configuration)
        {
            LocalConfiguration localConfigurations=
               configuration.Get<LocalConfiguration> ();

            string apiBaseUrl = localConfigurations.ApiConfiguration.Url;
            this.httpClient.BaseAddress = new Uri (apiBaseUrl);
            string accesToken = GetToken();

            this.httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accesToken);

            return new RESTFulApiFactoryClient(this.httpClient);
        }

        private string GetToken() => "";

    }
}
