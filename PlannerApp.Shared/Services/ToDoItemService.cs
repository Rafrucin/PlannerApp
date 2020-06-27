using AKSoftware.WebApi.Client;
using PlannerApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlannerApp.Shared.Services
{
    public class ToDoItemService
    {
        private readonly string _baseUrl;

        ServiceClient client = new ServiceClient();

        public ToDoItemService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public string AccessToken
        {
            get => client.AccessToken;
            set
            {
                client.AccessToken = value;
            }
        }

        public async Task<ToDoItemSingleResponse> CreateItemAsync(ToDoItemRequest model)
        {
            var response = await client.PostProtectedAsync<ToDoItemSingleResponse>($"{_baseUrl}/api/todoitems", model);
            return response.Result;
        }

        public async Task<ToDoItemSingleResponse> EditItemAsync(ToDoItemRequest model)
        {
            var response = await client.PutProtectedAsync<ToDoItemSingleResponse>($"{_baseUrl}/api/todoitems", model);
            return response.Result;
        }

        public async Task<ToDoItemSingleResponse> ChangeItemStateAsync(string id)
        {
            var response = await client.PutProtectedAsync<ToDoItemSingleResponse>($"{_baseUrl}/api/todoitems/{id}", null);
            return response.Result;
        }

        public async Task<ToDoItemSingleResponse> DeleteItemAsync(string id)
        {
            var response = await client.DeleteProtectedAsync<ToDoItemSingleResponse>($"{_baseUrl}/api/todoitems/{id}");
            return response.Result;
        }

    }
}
