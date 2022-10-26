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

namespace Google.Cloud.DiscoveryEngine.V1Beta.Snippets
{
    // [START discoveryengine_v1beta_generated_DocumentService_CreateDocument_sync_flattened_resourceNames]
    using Google.Cloud.DiscoveryEngine.V1Beta;

    public sealed partial class GeneratedDocumentServiceClientSnippets
    {
        /// <summary>Snippet for CreateDocument</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateDocumentResourceNames()
        {
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]");
            Document document = new Document();
            string documentId = "";
            // Make the request
            Document response = documentServiceClient.CreateDocument(parent, document, documentId);
        }
    }
    // [END discoveryengine_v1beta_generated_DocumentService_CreateDocument_sync_flattened_resourceNames]
}