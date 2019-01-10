// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IChicken.cs" company="RHEA System S.A.">
//    Copyright (c) 2019 RHEA System S.A.
//
//    Author: Sam Gerené
//
//    This file is part of the Chicken
//
//    The Chicken is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The Chicken is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Chicken
{
    /// <summary>
    /// A type of domesticated fowl, a subspecies of the red junglefowl; scientific name: Gallus gallus domesticus
    /// </summary>
    public interface IChicken
    {
        /// <summary>
        /// take part in a violent struggle involving the exchange of physical blows
        /// </summary>
        /// <param name="chicken"></param>
        void Fight(IChicken chicken);

        /// <summary>
        /// wash by immersing one's body in dust.
        /// </summary>
        void Bathe();

        /// <summary>
        /// move at a regular pace by lifting and setting down each foot in turn, never having both feet off the ground at once.
        /// </summary>
        void Walk();

        /// <summary>
        /// Move through the air using wings
        /// </summary>
        void Fly();

        /// <summary>
        /// Put (food) into beak and swallow it.
        /// </summary>
        void Eat();

        /// <summary>
        /// Make a short, low sound
        /// </summary>
        void Cluck();

        /// <summary>
        /// Gets the age of the <see cref="IChicken"/> expressed in days.
        /// </summary>
        int Age { get; }

        /// <summary>
        /// Gets the pecking order of the <see cref="IChicken"/>. The pecking order determines the priority to
        /// access for food and nesting locations. 
        /// </summary>
        int PeckingOrder { get; }
    }
}