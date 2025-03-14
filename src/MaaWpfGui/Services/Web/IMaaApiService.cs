﻿// <copyright file="IMaaApiService.cs" company="MaaAssistantArknights">
// MaaWpfGui - A part of the MaaCoreArknights project
// Copyright (C) 2021 MistEO and Contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY
// </copyright>

using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MaaWpfGui.Services.Web
{
    public interface IMaaApiService
    {
        Task<JObject> RequestMaaApiWithCache(string api);

        JObject LoadApiCache(string api);
    }
}
