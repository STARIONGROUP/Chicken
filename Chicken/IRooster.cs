// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRooster.cs" company="RHEA System S.A.">
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
    /// The definition of the <see cref="IRooster"/> interface. An <see cref="IRooster"/> is a male <see cref="IChicken"/>
    /// </summary>
    interface IRooster : IChicken
    {
        /// <summary>
        /// Initiate the mating ritual with a <see cref="IHen"/> which may end in mating or not.
        /// </summary>
        /// <param name="hen"></param>
        void Court(IHen hen);

        /// <summary>
        /// Come together with a <see cref="IHen"/> to breed.
        /// </summary>
        /// <param name="hen">
        /// The <see cref="IHen"/> with which the <see cref="IRooster"/> is mating.
        /// </param>
        void Mate(IHen hen);

        /// <summary>
        /// Executes a loud and sometimes shrill call and sends a territorial signal to other roosters.
        /// </summary>
        void Crow();

        /// <summary>
        /// Castrate the <see cref="IRooster"/>.
        /// </summary>
        void Castrate();

        /// <summary>
        /// A value indicating whether the <see cref="IRooster"/> is castrated or not.
        /// </summary>
        bool IsCastrated { get; }

        /// <summary>
        /// Gets a value expressing the sexual state, which is age dependent, of the <see cref="IRooster"/>
        /// </summary>
        MaleSexualState SexualState { get; }
    }
}