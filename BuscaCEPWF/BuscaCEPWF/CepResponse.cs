using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaCEPWF
{
    internal class CepResponse
    {
        [JsonProperty("maskCep")]

        public string Cep { get; set; }
        [JsonProperty("logradouro")]

        public string Logradouro { get; set; }
        [JsonProperty("complemento")]

        public string Complemento { get; set; }
        [JsonProperty("Bairro")]

        public string Bairro { get; set; }
        [JsonProperty("localidade")]

        public string Localidade { get; set; }
        [JsonProperty("uf")]

        public string Uf { get; set; }
        [JsonProperty("unidade")]

        public string Unidade { get; set; }
        [JsonProperty("ibge")]

        public string Ibge { get; set; }
        [JsonProperty("Gia")]

        public string Gia { get; set; }
 
    }
}
