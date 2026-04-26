using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tpmodul9_103082400044;

namespace tpmodul9_103082400044.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Pradipta", "103082400044"),
            new Mahasiswa("Salman", "103082400020"),
            new Mahasiswa("Jericho", "103082400022")

        };

        // GET: /api/mahasiswa
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // GET: /api/mahasiswa/{index}
        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id < 0 || id >= dataMahasiswa.Count)
            {
                return NotFound("Index tidak ditemukan");
            }
            return dataMahasiswa[id];
        }

        // POST: /api/mahasiswa
        [HttpPost]
        public IActionResult Post([FromBody] Mahasiswa mahasiswaBaru)
        {
            dataMahasiswa.Add(mahasiswaBaru);
            return Ok();
        }

        // DELETE: /api/mahasiswa/{index}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= dataMahasiswa.Count)
            {
                return NotFound("Index tidak ditemukan");
            }
            dataMahasiswa.RemoveAt(id);
            return Ok();
        }
    }
}
