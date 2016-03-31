﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniConfiguration.Interfaces
{
    /// <summary>
    /// The interface for backlog that provides information about parsing configuration.
    /// </summary>
    public interface IParsingBacklog
    {
        /// <summary>
        /// A parsing error occured at the specified line.
        /// </summary>
        /// <param name="lineIndex"></param>
        /// <param name="message"></param>
        void ParsingError(int lineIndex, string message);

        /// <summary>
        /// A duplicate section was found in configuration.
        /// </summary>
        /// <param name="lineIndex"></param>
        /// <param name="sectionName"></param>
        void DuplicateSection(int lineIndex, string sectionName);
    }
}
