using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prueba2.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    string connectionString = "server=127.0.0.1;user id=root;password=root;port=3306;database=Score;SslMode=none";
        //    string query = "INSERT INTO puntajeJugador (Puntaje) values (3)";

        //    MySqlConnection Conexion = new MySqlConnection(connectionString);
        //    MySqlCommand comandos = new MySqlCommand(query, Conexion);
        //    comandos.CommandTimeout = 60;

        //    try
        //    {
        //        Conexion.Open();
        //        MySqlDataReader myReader = comandos.ExecuteReader();

        //        return new string[] { "Guardado" };
        //    }
        //    catch
        //    {
        //        return new string[] {"Error"};
        //    }
        //}

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]puntajes value)
        {
            var pj = new puntajes();
            string connectionString = "server=127.0.0.1;user id=root;password=root;port=3306;database=Score;SslMode=none";
            //string query = string.Format("INSERT INTO puntajeJugador (Puntaje) values ('{0}')",value);
;
          
            MySqlConnection Conexion = new MySqlConnection(connectionString);
            MySqlCommand comandos = new MySqlCommand(string.Format("INSERT INTO puntajeJugador (Puntaje) values ('{0}')",pj.puntos), Conexion);
            comandos.CommandTimeout = 60;

            try
            {
                Conexion.Open();
                MySqlDataReader myReader = comandos.ExecuteReader();

                //string[] { "Guardado" };
            }
            catch
            {
                //string[] { "Error" };
            }
        }

        public class puntajes
        {
            public string puntos { get; set; }
        };


        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
    
