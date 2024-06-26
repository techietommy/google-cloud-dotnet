// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Logging;
using Google.Cloud.Translation.V2;
using static Google.Apis.Http.ConfigurableMessageHandler;

namespace Google.Cloud.Tools.Snippets
{
    public class FaqSnippets
    {
        public void RestLogging()
        {
            // Sample: RestLogging
            // Required using directives:
            // using static Google.Apis.Http.ConfigurableMessageHandler;
            // using Google;
            // using Google.Apis.Logging;
            // using Google.Cloud.Translation.V2;

            // Register a verbose console logger
            ApplicationContext.RegisterLogger(new ConsoleLogger(LogLevel.All));

            // Create a translation client
            TranslationClient client = TranslationClient.Create();

            // Configure which events the message handler will log.
            client.Service.HttpClient.MessageHandler.LogEvents =
                LogEventType.RequestHeaders | LogEventType.ResponseBody;

            // Make the request
            client.ListLanguages();
            // End sample
        }
    }
}
