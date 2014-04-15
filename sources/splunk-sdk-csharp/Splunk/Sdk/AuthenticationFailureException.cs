﻿/*
 * Copyright 2014 Splunk, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"): you may
 * not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

// TODO: Documentation

namespace Splunk.Sdk
{
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// The exception that is thrown when invalid credentials are passed to
    /// <see cref="Service.LoginAsync"/> or a request fails because the session 
    /// timed out.
    /// </summary>
    public sealed class AuthenticationFailureException : RequestException
    {
        #region Constructors

        internal AuthenticationFailureException(HttpResponseMessage message, IEnumerable<Message> details)
            : base(message, details)
        { }

        #endregion
    }
}
