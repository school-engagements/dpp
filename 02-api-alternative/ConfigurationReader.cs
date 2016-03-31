﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_api_alternative.Definitions;

namespace _02_api_alternative
{
    /// <summary>
    /// The class used to read configuration from a stream.
    /// </summary>
    public class ConfigurationReader
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationReader"/> class with an optional configuration schema.
        /// </summary>
        /// <param name="schema">The configuration schema.</param>
        public ConfigurationReader(Schema schema = null)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Reads the configuration.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="strict"></param>
        /// <returns></returns>
        public Configuration Read(Stream stream, bool strict)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
