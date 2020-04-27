using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ARU_Server.Models;
using System.Threading.Tasks;

namespace ARU_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        string jsonFilePath = @"Models\Inventory.json";

        // GET: api/Inventory
        [HttpGet]
        public List<InventoryItem> Get()
        {
            var result = ReadInventoryData();

            return result;
        }

        // GET: api/Inventory/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Inventory
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Inventory/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<InventoryItem> ReadInventoryData()
        {
            List<InventoryItem> inventories = new List<InventoryItem>();

            inventories.Add(new InventoryItem
            {
                Name = "BSS DSP",
                Model = "Model 1",                
                Price = 3000,
                Imagepath= "assets/images/BSS_DSP_1.jpg"
            });
            inventories.Add(new InventoryItem
            {
                Name = "BSS DSP",
                Model = "Model 2",
                Price = 4000,
                Imagepath = "assets/images/BSS_DSP_2.jpg"
            });
            inventories.Add(new InventoryItem
            {
                Name = "Crown Amp",
                Model = "Model 1",
                Price = 5000,
                Imagepath = "assets/images/crown_1.jpg"
            });
            inventories.Add(new InventoryItem
            {
                Name = "Crown Amp",
                Model = "Model 2",
                Price = 7000,
                Imagepath = "assets/images/crown_2.jpg"
            });
            inventories.Add(new InventoryItem
            {
                Name = "JBL Speaker",
                Model = "1",
                Price = 50,
                Imagepath = "assets/images/JBL_1.jpg"
            });
            inventories.Add(new InventoryItem
            {
                Name = "JBL Speaker",
                Model = "2",
                Price = 200,
                Imagepath = "assets/images/JBL_2.jpg"
            });
            inventories.Add(new InventoryItem
            {
                Name = "JBL Speaker",
                Model = "3",
                Price = 1000,
                Imagepath = ""
            });
            inventories.Add(new InventoryItem
            {
                Name = "AKG Mic",
                Model = "1",
                Price = 110,
                Imagepath = "assets/images/AKG_1.jpg"
            });
            inventories.Add(new InventoryItem
            {
                Name = "AKG Mic",
                Model = "2",
                Price = 250,
                Imagepath = "assets/images/AKG_2.jpg"
            });
            inventories.Add(new InventoryItem
            {
                Name = "SoundCraft Mixer",
                Model = "8 channel",
                Price = 400,
                Imagepath = ""
            });
            inventories.Add(new InventoryItem
            {
                Name = "SoundCraft Mixer",
                Model = "24 channel",
                Price = 1000,
                Imagepath = ""
            });
            inventories.Add(new InventoryItem
            {
                Name = "AMX Touch Screen",
                Model = "8",
                Price = 2000,
                Imagepath = ""
            });
            inventories.Add(new InventoryItem
            {
                Name = "AMX Control",
                Model = "Master",
                Price = 3000,
                Imagepath = ""
            });

            return inventories;
        }
    }
}
