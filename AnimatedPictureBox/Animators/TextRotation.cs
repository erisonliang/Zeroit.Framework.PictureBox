﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.PictureBox
// Author           : ZEROIT
// Created          : 12-20-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-20-2018
// ***********************************************************************
// <copyright file="TextRotation.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.PictureBox
{
    #region ExtendedPictureBoxTextRotationAngleAnimator
    /// <summary>
    /// Class inheriting <see cref="Animations.AnimatorBase" /> to animate the
    /// <see cref="ExtendedPictureBoxLib.ExtendedPictureBox.TextRotationAngle" /> of a
    /// <see cref="ExtendedPictureBox" />.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.PictureBox.ZeroitEXPicBoxAngleAnimator" />
	public class ZeroitEXPicBoxTextAngleAnimator : ZeroitEXPicBoxAngleAnimator
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="container">Container the new instance should be added to.</param>
        public ZeroitEXPicBoxTextAngleAnimator(IContainer container) : base(container) { }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        public ZeroitEXPicBoxTextAngleAnimator() : base() { }

        #endregion

        #region Overridden from ExtendedPictureBoxRotationAngleAnimator		

        /// <summary>
        /// Gets or sets the <see cref="ExtendedPictureBox" /> which
        /// <see cref="ExtendedPictureBoxLib.ExtendedPictureBox.TextRotationAngle" /> should be animated.
        /// </summary>
        /// <value>The zeroit ex pic box.</value>
        [Browsable(true), DefaultValue(null), Category("Behavior")]
        [RefreshProperties(RefreshProperties.Repaint)]
        [Description("Gets or sets which ExtendedPictureBox should be animated.")]
        public override ZeroitEXPicBox ZeroitEXPicBox
        {
            get { return ZeroitEXPicBoxInternal; }
            set
            {
                if (ZeroitEXPicBoxInternal == value)
                    return;

                if (ZeroitEXPicBoxInternal != null)
                    ZeroitEXPicBoxInternal.TextRotationAngleChanged -= new EventHandler(OnCurrentValueChanged);

                ZeroitEXPicBoxInternal = value;

                if (ZeroitEXPicBoxInternal != null)
                    ZeroitEXPicBoxInternal.TextRotationAngleChanged += new EventHandler(OnCurrentValueChanged);

                base.ResetValues();
            }
        }

        /// <summary>
        /// Gets or sets the currently shown value.
        /// </summary>
        /// <value>The current value internal.</value>
        protected override object CurrentValueInternal
        {
            get { return ZeroitEXPicBox == null ? (float)0 : ZeroitEXPicBox.TextRotationAngle; }
            set
            {
                if (ZeroitEXPicBox != null)
                    ZeroitEXPicBox.TextRotationAngle = (float)value;
            }
        }

        #endregion
    }
    #endregion


}
