﻿using Disqord.Logging;
using Disqord.Serialization.Json;

namespace Disqord.Rest
{
    public class RestDiscordClientConfiguration
    {
        /// <summary>
        ///     Gets or sets the logger the client should use.
        /// </summary>
        public Optional<ILogger> Logger { get; set; }

        /// <summary>
        ///     Gets or sets the JSON serializer the client should use.
        /// </summary>
        public Optional<IJsonSerializer> Serializer { get; set; }
    }
}
