﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.PictureBox
// Author           : ZEROIT
// Created          : 12-20-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-20-2018
// ***********************************************************************
// <copyright file="ProgressStepCollection.cs" company="Zeroit Dev Technologies">
//    This program is for creating Image controls.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System.Collections;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.PictureBox
{

    #region ProgressStepCollection
    /// <summary>
    /// A typesafe collection class for <see cref="ProgressStep"/> instances.
    /// </summary>
    public class ZeroitProgressStepCollection : CollectionBase
    {
        #region Constructors

        /// <summary>
        /// Creats a new empty instance.
        /// </summary>
        public ZeroitProgressStepCollection() { }

        #endregion

        #region Public interface

        /// <summary>
        /// Adds a <see cref="ProgressStep"/> to the end of the collection.
        /// </summary>
        /// <param name="progressStep">Step to be added.</param>
        public void Add(ZeroitProgressStep progressStep)
        {
            base.InnerList.Add(progressStep);
        }

        /// <summary>
        /// Removes a <see cref="ProgressStep"/> from the collection.
        /// </summary>
        /// <param name="progressStep">Step to be removed.</param>
        public void Remove(ZeroitProgressStep progressStep)
        {
            base.InnerList.Remove(progressStep);
        }

        /// <summary>
        /// Gets a <see cref="ProgressStep"/> from a specified position.
        /// </summary>
        public ZeroitProgressStep this[int index]
        {
            get { return (ZeroitProgressStep)base.InnerList[index]; }
        }

        #endregion
    }
    #endregion


}
