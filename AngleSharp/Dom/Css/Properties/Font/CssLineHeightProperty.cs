﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Css.Values;
    using AngleSharp.Extensions;

    /// <summary>
    /// Information:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/line-height
    /// </summary>
    sealed class CssLineHeightProperty : CssProperty
    {
        #region ctor

        internal CssLineHeightProperty()
            : base(PropertyNames.LineHeight, PropertyFlags.Inherited | PropertyFlags.Animatable)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return Converters.LineHeightConverter; }
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return new Length(120f, Length.Unit.Percent);
        }

        protected override Boolean IsValid(CssValue value)
        {
            return Converters.LineHeightConverter.Validate(value);
        }

        #endregion
    }
}
