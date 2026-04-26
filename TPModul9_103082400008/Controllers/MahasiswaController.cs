using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TPModul9_103082400008;

namespace MahasiswaController.Controllers
{
    [Route("api/mahasiswa")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static LinkedList<Mahasiswa> listMahasiswa = new LinkedList<Mahasiswa>(new[]
        {
            new Mahasiswa { nama = "Ruben", NIM = "103082400008" },
            new Mahasiswa { nama = "Joko", NIM = "109078492181" },
            new Mahasiswa { nama = "Cheline", NIM = "873569835108" }
        });

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa.ElementAt(id);
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mhs)
        {
            listMahasiswa.AddLast(mhs);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var target = listMahasiswa.ElementAt(id);
            listMahasiswa.Remove(target);
        }
    }
}

