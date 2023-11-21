using CineCordobaBack.Entidades;
using CineCordobaBack.Entidades.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaFront.Cliente
{
    public class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient client;

        public ClienteSingleton()
        {
            client = new HttpClient();
        }

        public static ClienteSingleton ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ClienteSingleton();
            }
            return instancia;
        }

        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> PostAsync(string url, DtoComprobantesR comprobante)
        {
            // Serializar el objeto Comprobantes, incluyendo la lista de detalles
            string comprobanteJson = JsonConvert.SerializeObject(comprobante);

            // Configurar el contenido de la solicitud con el objeto serializado
            StringContent content = new StringContent(comprobanteJson, Encoding.UTF8, "application/json");

            // Realizar la solicitud POST
            var result = await client.PostAsync(url, content);
            var response = "";

            // Verificar si la solicitud fue exitosa
            if (result.IsSuccessStatusCode)
            {
                // Leer la respuesta del servicio web
                response = await result.Content.ReadAsStringAsync();
            }

            return response;
        }
    }
}
