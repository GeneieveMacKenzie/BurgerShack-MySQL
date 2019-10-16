using System;
using System.Collections.Generic;
using burger.Models;
using Items.Services;
using Microsoft.AspNetCore.Mvc;

//copied from weather forecast
namespace burgers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ItemService _is;
        public ItemController(ItemService iservice)
        {
            _is = iservice;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get() //IEnumerable is a GetAll
        {
            try
            {
                return Ok(_is.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<Item> Get(string id)
        {
            try
            {
                return Ok(_is.Get(id));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Item> Post([FromBody] Item newItem)
        {
            try
            {
                return Ok(_is.Create(newItem));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Item> Edit(string id, [FromBody] Item editItemData)
        {
            try
            {
                editItemData.Id = id;
                return Ok(_is.Edit(editItemData));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}