// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING
// WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF
// TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR
// NON-INFRINGEMENT.
// See the Apache 2 License for the specific language governing
// permissions and limitations under the License.

// <auto-generated />

namespace Microsoft.AspNet.Razor
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class CommonResources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Razor.CommonResources", typeof(CommonResources).GetTypeInfo().Assembly);

        /// <summary>
        /// Value cannot be null or an empty string.
        /// </summary>
        internal static string Argument_Cannot_Be_Null_Or_Empty
        {
            get { return GetString("Argument_Cannot_Be_Null_Or_Empty"); }
        }

        /// <summary>
        /// Value must be between {0} and {1}.
        /// </summary>
        internal static string Argument_Must_Be_Between(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Argument_Must_Be_Between"), p0, p1);
        }

        /// <summary>
        /// Value must be a value from the "{0}" enumeration.
        /// </summary>
        internal static string Argument_Must_Be_Enum_Member(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Argument_Must_Be_Enum_Member"), p0);
        }

        /// <summary>
        /// Value must be greater than {0}.
        /// </summary>
        internal static string Argument_Must_Be_GreaterThan(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Argument_Must_Be_GreaterThan"), p0);
        }

        /// <summary>
        /// Value must be greater than or equal to {0}.
        /// </summary>
        internal static string Argument_Must_Be_GreaterThanOrEqualTo(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Argument_Must_Be_GreaterThanOrEqualTo"), p0);
        }

        /// <summary>
        /// Value must be less than {0}.
        /// </summary>
        internal static string Argument_Must_Be_LessThan(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Argument_Must_Be_LessThan"), p0);
        }

        /// <summary>
        /// Value must be less than or equal to {0}.
        /// </summary>
        internal static string Argument_Must_Be_LessThanOrEqualTo(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Argument_Must_Be_LessThanOrEqualTo"), p0);
        }

        /// <summary>
        /// Value cannot be an empty string. It must either be null or a non-empty string.
        /// </summary>
        internal static string Argument_Must_Be_Null_Or_Non_Empty
        {
            get { return GetString("Argument_Must_Be_Null_Or_Non_Empty"); }
        }

        private static string GetString(string name)
        {
            string value = _resourceManager.GetString(name);
            System.Diagnostics.Debug.Assert(value != null);
            return value;
        }
    }
}
