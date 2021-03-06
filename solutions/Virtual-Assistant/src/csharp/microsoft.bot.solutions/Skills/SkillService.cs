﻿using Microsoft.Bot.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Microsoft.Bot.Solutions.Skills
{
    public class SkillService : ConnectedService
    {
        public SkillService() : base("skill")
        {
        }

        [JsonProperty("dispatchIntent")]
        public string DispatchIntent { get; set; }

        [JsonProperty("assembly")]
        public string Assembly { get; set; }

        [JsonProperty("authConnectionName")]
        public string AuthConnectionName { get; set; }

        [JsonProperty("luisServiceId")]
        public string LuisServiceId { get; set; }

        [JsonProperty("parameters")]
        public string[] Parameters { get; set; }

        [JsonProperty("configuration")]
        public Dictionary<string, string> Configuration { get; set; } = new Dictionary<string, string>();

        public override void Decrypt(string secret)
        {
            base.Decrypt(secret);
        }

        public override void Encrypt(string secret)
        {
            base.Encrypt(secret);
        }
    }
}
