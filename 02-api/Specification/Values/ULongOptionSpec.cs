﻿using Ini.EventLoggers;
using YamlDotNet.Serialization;

namespace Ini.Specification.Values
{
    /// <summary>
    /// The definition of an unsigned option.
    /// </summary>
    public class ULongOptionSpec : OptionSpec<ulong>
    {
        #region Properties

        /// <summary>
        /// The minimal value.
        /// </summary>
        [YamlMember(Alias = "min_value")]
        public ulong MinValue { get; set; }

        /// <summary>
        /// The maximal value.
        /// </summary>
        [YamlMember(Alias = "max_value")]
        public ulong MaxValue { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ULongOptionSpec"/> class.
        /// </summary>
        public ULongOptionSpec()
        {
            this.MinValue = ulong.MinValue;
            this.MaxValue = ulong.MaxValue;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Determines whether the specification block is valid.
        /// </summary>
        /// <returns><c>true</c> if this instance is valid; otherwise, <c>false</c>.</returns>
        /// <param name="sectionIdentifier">The containing section's identifier.</param>
        /// <param name="eventLogger">Specification validation event logger.</param>
        public override bool IsValid(string sectionIdentifier, ISpecValidatorEventLogger eventLogger)
        {
            bool result = base.IsValid(sectionIdentifier, eventLogger);
            foreach(double value in DefaultValues)
            {
                if((value < MinValue) || (value > MaxValue))
                {
                    result = false;
                    eventLogger.ValueOutOfRange(
                        sectionIdentifier,
                        Identifier,
                        value);
                }
            }
            return result;
        }

        #endregion
    }
}
