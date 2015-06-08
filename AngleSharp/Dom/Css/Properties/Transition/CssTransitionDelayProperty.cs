﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Css.Values;
    using AngleSharp.Extensions;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/CSS/transition-delay
    /// Gets the delays for the transitions.
    /// </summary>
    sealed class CssTransitionDelayProperty : CssProperty
    {
        #region Fields

        static readonly IValueConverter<Time[]> ListConverter =
            Converters.TimeConverter.FromList();

        #endregion

        #region ctor

        internal CssTransitionDelayProperty()
            : base(PropertyNames.TransitionDelay)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return ListConverter; }
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return Time.Zero;
        }

        protected override Boolean IsValid(CssValue value)
        {
            return ListConverter.Validate(value);
        }

        #endregion
    }
}
