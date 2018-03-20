using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Emp1.Models;

[assembly: Xamarin.Forms.Dependency(typeof(Emp1.Services.MockDataStore))]
namespace Emp1.Services
{
    public class MockDataStore : IDataStore<EmpRec>
    {
        List<EmpRec> Some;

        public MockDataStore()
        {
            Some = new List<EmpRec>();
            //var mockItems = new List<Item>
            //{
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
            //};

            //foreach (var item in mockItems)
            //{
            //    items.Add(item);
            //}
        }

        public async Task<bool> AddItemAsync(EmpRec item)
        {
            //items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(EmpRec item)
        {
            //var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            //items.Remove(_item);
            //items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(EmpRec item)
        {
            //var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            //items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<EmpRec> GetItemAsync(string id)
        {
            return await Task.FromResult(Some.FirstOrDefault(s => s.ToString() ==""));
        }

        public async Task<IEnumerable<EmpRec>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Some);
        }
    }
}