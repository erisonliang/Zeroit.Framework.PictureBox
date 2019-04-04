﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.PictureBox
// Author           : ZEROIT
// Created          : 12-20-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-20-2018
// ***********************************************************************
// <copyright file="TextOffset.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.PictureBox
{
    #region ExtendedPictureBoxTextOffsetAnimator
    /// <summary>
    /// Class inheriting <see cref="Animations.AnimatorBase" /> to animate the
    /// <see cref="ExtendedPictureBoxLib.ExtendedPictureBox.TextOffset" /> of a
    /// <see cref="ExtendedPictureBox" />.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.PictureBox.ZeroitEXPicBoxOffsetAnimatorBase" />
    public class ZeroitEXPicBoxTextOffsetAnimator : ZeroitEXPicBoxOffsetAnimatorBase
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="container">Container the new instance should be added to.</param>
        public ZeroitEXPicBoxTextOffsetAnimator(IContainer container) : base(container) { }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        public ZeroitEXPicBoxTextOffsetAnimator() { }

        #endregion

        #region Overridden from AnimatorBase

        /// <summary>
        /// Gets or sets the <see cref="ExtendedPictureBox" /> which
        /// <see cref="ExtendedPictureBox" /> should be animated.
        /// </summary>
        /// <value>The zeroit ex pic box.</value>
        public override ZeroitEXPicBox ZeroitEXPicBox
        {
            get { return base.ZeroitEXPicBox; }
            set
            {
                if (base.ZeroitEXPicBox != null)
                    base.ZeroitEXPicBox.TextOffsetChanged -= new EventHandler(OnCurrentValueChanged);

                base.ZeroitEXPicBox = value;

                if (base.ZeroitEXPicBox != null)
                    base.ZeroitEXPicBox.TextOffsetChanged += new EventHandler(OnCurrentValueChanged);
            }
        }

        /// <summary>
        /// Gets or sets the currently shown value.
        /// </summary>
        /// <value>The current offset.</value>
        protected override Point CurrentOffset
        {
            get { return base.ZeroitEXPicBox.TextOffset; }
            set { base.ZeroitEXPicBox.TextOffset = value; }
        }

        #endregion
    }
    #endregion


}
