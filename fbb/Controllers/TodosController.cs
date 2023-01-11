﻿using fbb.Models;
using fbb.Sevice.Todos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fbb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosService _todoService;
        public TodosController(ITodosService todoService)
        {
            _todoService = todoService;
        }
        // GET: api/<TodosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todoService.GetTodos());
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodosController>
        [HttpPost]
        public IActionResult Post(Todo todo)
        {
            return Ok(_todoService.AddTodo(todo));
        }

        // PUT api/<TodosController>/5
        [HttpPut]
        public IActionResult Put(Todo todo)
        {
            return Ok(_todoService.UpdateTodo(todo));

        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_todoService.DelTodo(id));

        }
    }
}
