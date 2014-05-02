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

namespace TestOutput
{
    using System;
    using System.Threading.Tasks;

    public class Blocks
    {
        #line hidden
        public Blocks()
        {
        }

        public override async Task ExecuteAsync()
        {
#line 1 "Blocks.cshtml"
  
    int i = 1;

#line default
#line hidden

            WriteLiteral("\r\n\r\n");
#line 5 "Blocks.cshtml"
 while(i <= 10) {

#line default
#line hidden

            WriteLiteral("    <p>Hello from C#, #");
            Write(
#line 6 "Blocks.cshtml"
                         i

#line default
#line hidden
            );

            WriteLiteral("</p>\r\n");
#line 7 "Blocks.cshtml"
    i += 1;
}

#line default
#line hidden

            WriteLiteral("\r\n");
#line 10 "Blocks.cshtml"
 if(i == 11) {

#line default
#line hidden

            WriteLiteral("    <p>We wrote 10 lines!</p>\r\n");
#line 12 "Blocks.cshtml"
}

#line default
#line hidden

            WriteLiteral("\r\n");
#line 14 "Blocks.cshtml"
 switch(i) {
    case 11:

#line default
#line hidden

            WriteLiteral("        <p>No really, we wrote 10 lines!</p>\r\n");
#line 17 "Blocks.cshtml"
        break;
    default:

#line default
#line hidden

            WriteLiteral("        <p>Actually, we didn\'t...</p>\r\n");
#line 20 "Blocks.cshtml"
        break;
}

#line default
#line hidden

            WriteLiteral("\r\n");
#line 23 "Blocks.cshtml"
 for(int j = 1; j <= 10; j += 2) {

#line default
#line hidden

            WriteLiteral("    <p>Hello again from C#, #");
            Write(
#line 24 "Blocks.cshtml"
                               j

#line default
#line hidden
            );

            WriteLiteral("</p>\r\n");
#line 25 "Blocks.cshtml"
}

#line default
#line hidden

            WriteLiteral("\r\n");
#line 27 "Blocks.cshtml"
 try {

#line default
#line hidden

            WriteLiteral("    <p>That time, we wrote 5 lines!</p>\r\n");
#line 29 "Blocks.cshtml"
} catch(Exception ex) {

#line default
#line hidden

            WriteLiteral("    <p>Oh no! An error occurred: ");
            Write(
#line 30 "Blocks.cshtml"
                                   ex.Message

#line default
#line hidden
            );

            WriteLiteral("</p>\r\n");
#line 31 "Blocks.cshtml"
}

#line default
#line hidden

            WriteLiteral("\r\n<p>i is now ");
            Write(
#line 33 "Blocks.cshtml"
             i

#line default
#line hidden
            );

            WriteLiteral("</p>\r\n\r\n");
#line 35 "Blocks.cshtml"
 lock(new object()) {

#line default
#line hidden

            WriteLiteral("    <p>This block is locked, for your security!</p>\r\n");
#line 37 "Blocks.cshtml"
}

#line default
#line hidden

        }
    }
}
