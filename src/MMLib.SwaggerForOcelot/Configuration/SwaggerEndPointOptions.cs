﻿using System.Net;
using System.Collections.Generic;
using System.Linq;

namespace MMLib.SwaggerForOcelot.Configuration
{
    /// <summary>
    /// Swagger endpoint configuration.
    /// </summary>
    public class SwaggerEndPointOptions
    {
        /// <summary>
        /// The configuration section name.
        /// </summary>
        public const string ConfigurationSectionName = "SwaggerEndPoints";

        /// <summary>
        /// Swagger endpoint key, which have to corresponding with <see cref="RouteOptions.SwaggerKey"/>.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Swagger version placeholder..
        /// </summary>
        public string VersionPlaceholder { get; set; } = "{version}";

        /// <summary>
        /// Gets the path from key.
        /// </summary>
        public string KeyToPath => WebUtility.UrlEncode(Key);
        /// <summary>
        /// The swagger endpoint config collection
        /// </summary>
        public List<SwaggerEndPointConfig> Config { get; set; }

        /// <summary>
        /// This host url is use used to overwrite the host of the upstream service.
        /// </summary>
        public string HostOverride { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether documentation will be transform by ocelot configuration.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [transform by ocelot configuration]; otherwise, <c>false</c>.
        /// </value>
        public bool TransformByOcelotConfig { get; set; } = true;

        internal bool IsGatewayItSelf => Config != null && Config.Any(c => c.IsGatewayItSelf);
    }
}
