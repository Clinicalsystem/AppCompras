﻿using Newtonsoft.Json;

namespace AppCompras.Models.Autentication
{
    public class ResponseTokenRefesh
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("project_id")]
        public string ProyectId { get; set; }


        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("id_token")]
        public string IdToken { get; set; }


        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }
    }
}
