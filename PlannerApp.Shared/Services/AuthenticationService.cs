using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using PlannerApp.Shared.Models;

namespace PlannerApp.Shared.Services
{
    public class AuthenticationService
    {
        private readonly string _baseUrl;

        ServiceClient client = new ServiceClient();

        public AuthenticationService (string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<UserManagerResponse> RegisterUserAsync (RegisterRequestModel request)
        {
            var respones = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/Auth/Register", request);
            return respones.Result;
        }

        public async Task<UserManagerResponse> LoginUserAsync(LoginRequest request)
        {
            var respones = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/Auth/Login", request);
            return respones.Result;
        }
    }
}
