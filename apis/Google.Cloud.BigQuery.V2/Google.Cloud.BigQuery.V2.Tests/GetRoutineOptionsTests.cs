﻿// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Xunit;
using static Google.Apis.Bigquery.v2.RoutinesResource;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class GetRoutineOptionsTests
    {
        [Fact]
        public void ModifyRequest_NoOp()
        {
            var request = new GetRequest(null, "project", "dataset", "routine");
            var options = new GetRoutineOptions();
            options.ModifyRequest(request);

            Assert.Null(request.ReadMask);
        }

        [Fact]
        public void ModifyRequest()
        {
            var request = new GetRequest(null, "project", "dataset", "routine");
            var options = new GetRoutineOptions
            {
                ReadMask = "a,b,c"
            };
            options.ModifyRequest(request);

            Assert.Equal("a,b,c", request.ReadMask);
        }
    }
}
