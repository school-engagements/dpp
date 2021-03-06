﻿using Ini.Configuration.Base;
using Ini.EventLoggers;
using Ini.Specification;

namespace Ini.Configuration.Values
{
    /// <summary>
    /// Element of type <see cref="string"/>.
    /// </summary>
    public class StringValue : ValueBase<string>
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="StringValue"/> class.
        /// </summary>
        internal StringValue() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ini.Configuration.Values.StringValue"/> class.
        /// </summary>
        /// <param name="value">Initial value.</param>
        public StringValue(string value) : base(value)
        {
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Parses the string value and initializes the <see cref="ValueBase{T}.Value"/> property.
        /// </summary>
        /// <param name="value">The string.</param>
        public override void FillFromString(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Serializes this element into a string that can be deserialized back using <see cref="ConfigParser"/>.
        /// </summary>
        /// <param name="config">The parent configuration.</param>
        /// <returns>The element converted to a string.</returns>
        public override string ToOutputString(Config config)
        {
            return this.Value;
        }

        #endregion

        #region Validation

        /// <summary>
        /// Determines whether the element conforms to the given option specification.
        /// </summary>
        /// <param name="config">The parent configuration.</param>
        /// <param name="section">The current section.</param>
        /// <param name="specification">The current option's specification.</param>
        /// <param name="configLogger">Configuration validation event logger.</param>
        /// <returns></returns>
        public override bool IsValid(Config config, string section, OptionSpec specification, IConfigValidatorEventLogger configLogger)
        {
            return true;
        }

        #endregion
    }
}
