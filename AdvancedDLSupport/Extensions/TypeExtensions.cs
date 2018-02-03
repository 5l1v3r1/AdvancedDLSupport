﻿//
//  TypeExtensions.cs
//
//  Copyright (c) 2018 Firwood Software
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using JetBrains.Annotations;

namespace AdvancedDLSupport.Extensions
{
    /// <summary>
    /// Extension methods for the <see cref="Type"/> class.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Determines whether or not the given type is a complex type.
        /// </summary>
        /// <param name="this">The type.</param>
        /// <returns>true if the type is complex; otherwise, false.</returns>
        [PublicAPI, Pure]
        public static bool IsComplexType([NotNull] this Type @this)
        {
            return
                @this == typeof(string) ||
                @this == typeof(bool) ||
                (@this.IsGenericType && @this.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }
}