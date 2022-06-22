using MenuItemListing.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : Controller
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Id=101, Name="Bat", Active = true, FreeDelivery = false, Price = 5000, DateOfLaunch = new DateTime(2022,06,02)
                },

                new MenuItem()
                {
                    Id=102, Name="Ball", Active = true, FreeDelivery = false, Price = 50, DateOfLaunch = new DateTime(2022,06,02)
                },

                new MenuItem()
                {
                    Id=103, Name="Stumps", Active = true, FreeDelivery = false, Price = 2000, DateOfLaunch = new DateTime(2022,06,03)
                },

                new MenuItem()
                {
                    Id=104, Name="LegPads", Active = true, FreeDelivery = false, Price = 7000, DateOfLaunch = new DateTime(2022,06,03)
                },

                new MenuItem()
                {
                    Id=105, Name="Net", Active = true, FreeDelivery = false, Price = 2700, DateOfLaunch = new DateTime(2022,06,03)
                },

                new MenuItem()
                {
                    Id=106, Name="Gloves", Active = true, FreeDelivery = false, Price = 3300, DateOfLaunch = new DateTime(2022,06,04)
                }

            };
            return MenuList;            
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Id=101, Name="Bat", Active = true, FreeDelivery = false, Price = 5000, DateOfLaunch = new DateTime(2022,06,02)
                },

                new MenuItem()
                {
                    Id=102, Name="Ball", Active = true, FreeDelivery = false, Price = 50, DateOfLaunch = new DateTime(2022,06,02)
                },

                new MenuItem()
                {
                    Id=103, Name="Stumps", Active = true, FreeDelivery = false, Price = 2000, DateOfLaunch = new DateTime(2022,06,03)
                },

                new MenuItem()
                {
                    Id=104, Name="LegPads", Active = true, FreeDelivery = false, Price = 7000, DateOfLaunch = new DateTime(2022,06,03)
                },

                new MenuItem()
                {
                    Id=105, Name="Net", Active = true, FreeDelivery = false, Price = 2700, DateOfLaunch = new DateTime(2022,06,03)
                },

                new MenuItem()
                {
                    Id=106, Name="Gloves", Active = true, FreeDelivery = false, Price = 3300, DateOfLaunch = new DateTime(2022,06,04)
                }
            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;
        }
    }
}
