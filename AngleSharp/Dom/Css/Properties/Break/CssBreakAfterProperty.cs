﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Extensions;

    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/break-after
    /// Gets the selected break mode.
    /// </summary>
    sealed class CssBreakAfterProperty : CssProperty
    {
        #region ctor

        internal CssBreakAfterProperty()
            : base(PropertyNames.BreakAfter)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return Converters.BreakModeConverter; }
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return BreakMode.Auto;
        }

        protected override Boolean IsValid(CssValue value)
        {
            return Converters.BreakModeConverter.Validate(value);
        }

        #endregion
    }
}
