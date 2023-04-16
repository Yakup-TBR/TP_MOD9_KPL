using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302210113
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa1
    {
        public static List<Mahasiswa> _data = new List<Mahasiswa>
        {
            new Mahasiswa("Yakup Asmaidy Atanggae", "1302210113"),
            new Mahasiswa("Adit", "1302210114"),
            new Mahasiswa("Rheza", "1302210115"),
            new Mahasiswa("Fariz", "1302210116"),
            new Mahasiswa("Adi", "1302210117"),
        };
        // GET: api/<Mahasiswa>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return _data;
        }

        // GET api/<Mahasiswa>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

        // POST api/<Mahasiswa>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            _data.Add(value);
        }
        // DELETE api/<Mahasiswa>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id);
        }

        private void NotFound()
        {
            throw new NotImplementedException();
        }
    }
}
