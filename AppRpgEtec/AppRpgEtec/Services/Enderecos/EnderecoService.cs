using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndroidX.Browser.Trusted;
using AppRpgEtec.Models;

namespace AppRpgEtec.Services.Enderecos
{
    internal class EnderecoService : Request
    {

        private readonly Request _request;
     
        public EnderecoService()
        {
            _request = new Request();
         
        }

        private const string baseUrl = "https://nominatim.openstreetmap.org/search?format=json&q=}";
        public async Task<Endereco> BuscaPorCep(string cep)
        {
            string url = baseUrl + cep;
            Endereco endereco = await _request.GetAsync<Endereco>(url, "");
            return endereco;
        }

    }
}
