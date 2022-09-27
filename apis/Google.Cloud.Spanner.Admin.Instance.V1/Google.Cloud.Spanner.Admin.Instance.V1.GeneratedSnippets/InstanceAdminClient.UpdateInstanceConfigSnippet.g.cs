// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Spanner.Admin.Instance.V1.Snippets
{
    // [START spanner_v1_generated_InstanceAdmin_UpdateInstanceConfig_sync_flattened]
    using Google.Cloud.Spanner.Admin.Instance.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedInstanceAdminClientSnippets
    {
        /// <summary>Snippet for UpdateInstanceConfig</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateInstanceConfig()
        {
            // Create client
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceConfig instanceConfig = new InstanceConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> response = instanceAdminClient.UpdateInstanceConfig(instanceConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InstanceConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InstanceConfig, UpdateInstanceConfigMetadata> retrievedResponse = instanceAdminClient.PollOnceUpdateInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InstanceConfig retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END spanner_v1_generated_InstanceAdmin_UpdateInstanceConfig_sync_flattened]
}