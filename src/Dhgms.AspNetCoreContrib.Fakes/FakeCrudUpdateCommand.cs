﻿// Copyright (c) 2019 DHGMS Solutions and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace Dhgms.AspNetCoreContrib.Fakes
{
    using System.Diagnostics.CodeAnalysis;
    using System.Security.Claims;
    using Dhgms.AspNetCoreContrib.Controllers;

    /// <summary>
    /// Represents a fake CRUD update command.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class FakeCrudUpdateCommand : AuditableRequest<int, FakeCrudUpdateResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FakeCrudUpdateCommand"/> class.
        /// </summary>
        /// <param name="requestDto">the unique id for the request.</param>
        /// <param name="claimsPrincipal">the claims principal associated with the request.</param>
        public FakeCrudUpdateCommand(int requestDto, ClaimsPrincipal claimsPrincipal)
            : base(requestDto, claimsPrincipal)
        {
        }
    }
}
