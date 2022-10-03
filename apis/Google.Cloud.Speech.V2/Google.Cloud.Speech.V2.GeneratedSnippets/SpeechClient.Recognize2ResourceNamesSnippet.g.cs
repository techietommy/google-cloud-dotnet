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

namespace Google.Cloud.Speech.V2.Snippets
{
    // [START speech_v2_generated_Speech_Recognize_sync_flattened2_resourceNames]
    using Google.Cloud.Speech.V2;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedSpeechClientSnippets
    {
        /// <summary>Snippet for Recognize</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void Recognize2ResourceNames()
        {
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            RecognizerName recognizer = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]");
            RecognitionConfig config = new RecognitionConfig();
            FieldMask configMask = new FieldMask();
            string uri = "";
            // Make the request
            RecognizeResponse response = speechClient.Recognize(recognizer, config, configMask, uri);
        }
    }
    // [END speech_v2_generated_Speech_Recognize_sync_flattened2_resourceNames]
}