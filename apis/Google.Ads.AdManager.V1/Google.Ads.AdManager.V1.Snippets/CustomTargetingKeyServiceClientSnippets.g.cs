// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCustomTargetingKeyServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomTargetingKey</summary>
        public void GetCustomTargetingKeyRequestObject()
        {
            // Snippet: GetCustomTargetingKey(GetCustomTargetingKeyRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            GetCustomTargetingKeyRequest request = new GetCustomTargetingKeyRequest
            {
                CustomTargetingKeyName = CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
            };
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.GetCustomTargetingKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKeyAsync</summary>
        public async Task GetCustomTargetingKeyRequestObjectAsync()
        {
            // Snippet: GetCustomTargetingKeyAsync(GetCustomTargetingKeyRequest, CallSettings)
            // Additional: GetCustomTargetingKeyAsync(GetCustomTargetingKeyRequest, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomTargetingKeyRequest request = new GetCustomTargetingKeyRequest
            {
                CustomTargetingKeyName = CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
            };
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.GetCustomTargetingKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKey</summary>
        public void GetCustomTargetingKey()
        {
            // Snippet: GetCustomTargetingKey(string, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/customTargetingKeys/[CUSTOM_TARGETING_KEY]";
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.GetCustomTargetingKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKeyAsync</summary>
        public async Task GetCustomTargetingKeyAsync()
        {
            // Snippet: GetCustomTargetingKeyAsync(string, CallSettings)
            // Additional: GetCustomTargetingKeyAsync(string, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/customTargetingKeys/[CUSTOM_TARGETING_KEY]";
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.GetCustomTargetingKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKey</summary>
        public void GetCustomTargetingKeyResourceNames()
        {
            // Snippet: GetCustomTargetingKey(CustomTargetingKeyName, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            CustomTargetingKeyName name = CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]");
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.GetCustomTargetingKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKeyAsync</summary>
        public async Task GetCustomTargetingKeyResourceNamesAsync()
        {
            // Snippet: GetCustomTargetingKeyAsync(CustomTargetingKeyName, CallSettings)
            // Additional: GetCustomTargetingKeyAsync(CustomTargetingKeyName, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomTargetingKeyName name = CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]");
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.GetCustomTargetingKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeys</summary>
        public void ListCustomTargetingKeysRequestObject()
        {
            // Snippet: ListCustomTargetingKeys(ListCustomTargetingKeysRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            ListCustomTargetingKeysRequest request = new ListCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetingKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetingKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeysAsync</summary>
        public async Task ListCustomTargetingKeysRequestObjectAsync()
        {
            // Snippet: ListCustomTargetingKeysAsync(ListCustomTargetingKeysRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomTargetingKeysRequest request = new ListCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomTargetingKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetingKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeys</summary>
        public void ListCustomTargetingKeys()
        {
            // Snippet: ListCustomTargetingKeys(string, string, int?, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetingKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetingKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeysAsync</summary>
        public async Task ListCustomTargetingKeysAsync()
        {
            // Snippet: ListCustomTargetingKeysAsync(string, string, int?, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomTargetingKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetingKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeys</summary>
        public void ListCustomTargetingKeysResourceNames()
        {
            // Snippet: ListCustomTargetingKeys(NetworkName, string, int?, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetingKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetingKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeysAsync</summary>
        public async Task ListCustomTargetingKeysResourceNamesAsync()
        {
            // Snippet: ListCustomTargetingKeysAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomTargetingKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetingKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
