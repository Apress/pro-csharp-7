using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoLotDAL_Core2.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace AutoLotMVC_Core2.Controllers
{
    public class InventoryController : Controller
    {
        private readonly string _baseUrl;

        public InventoryController(IConfiguration configuration)
        {
            _baseUrl = configuration.GetSection("ServiceAddress").Value;
        }
        private async Task<Inventory> GetInventoryRecord(int id)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"{_baseUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                var inventory = JsonConvert.DeserializeObject<Inventory>(await response.Content.ReadAsStringAsync());
                return inventory;
            }
            return null;
        }
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(_baseUrl);
            if (response.IsSuccessStatusCode)
            {
                var items = JsonConvert.DeserializeObject<List<Inventory>>(await response.Content.ReadAsStringAsync());
                return View(items);
            }
            return NotFound();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var inventory = await GetInventoryRecord(id.Value);
            return inventory != null ? (IActionResult) View(inventory) : NotFound();
        }
        // GET: Inventory/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Inventory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Make,Color,PetName")] Inventory inventory)
        {
            if (!ModelState.IsValid) return View(inventory);
            try
            {
                var client = new HttpClient();
                string json = JsonConvert.SerializeObject(inventory);
                var response = await client.PostAsync(_baseUrl,
                    new StringContent(json, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Unable to create record: {ex.Message}");
            }
            return View(inventory);
        }

        // GET: Inventory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var inventory = await GetInventoryRecord(id.Value);
            return inventory != null ? (IActionResult)View(inventory) : NotFound();
        }
        // POST: Inventory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Make,Color,PetName,Id,Timestamp")] Inventory inventory)
        {
            if (id != inventory.Id) return BadRequest();
            if (!ModelState.IsValid) return View(inventory);
            var client = new HttpClient();
            string json = JsonConvert.SerializeObject(inventory);
            var response = await client.PutAsync($"{_baseUrl}/{inventory.Id}",
                new StringContent(json, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(inventory);
        }

        // GET: Inventory/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var inventory = await GetInventoryRecord(id.Value);
            return inventory != null ? (IActionResult)View(inventory) : NotFound();
        }

        // POST: Inventory/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([Bind("Id,Timestamp")] Inventory inventory)
        {
            var client = new HttpClient();
            var timeStampString = JsonConvert.SerializeObject(inventory.Timestamp);
            HttpRequestMessage request =
                new HttpRequestMessage(HttpMethod.Delete, $"{_baseUrl}/{inventory.Id}/{timeStampString}");
            await client.SendAsync(request);
            return RedirectToAction(nameof(Index));
        }
    }
}