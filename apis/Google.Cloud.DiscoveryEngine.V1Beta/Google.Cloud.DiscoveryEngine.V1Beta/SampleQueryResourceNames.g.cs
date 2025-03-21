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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Resource name for the <c>SampleQuery</c> resource.</summary>
    public sealed partial class SampleQueryName : gax::IResourceName, sys::IEquatable<SampleQueryName>
    {
        /// <summary>The possible contents of <see cref="SampleQueryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
            /// .
            /// </summary>
            ProjectLocationSampleQuerySetSampleQuery = 1,
        }

        private static gax::PathTemplate s_projectLocationSampleQuerySetSampleQuery = new gax::PathTemplate("projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}");

        /// <summary>Creates a <see cref="SampleQueryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SampleQueryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SampleQueryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SampleQueryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SampleQueryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQuerySetId">The <c>SampleQuerySet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQueryId">The <c>SampleQuery</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SampleQueryName"/> constructed from the provided ids.</returns>
        public static SampleQueryName FromProjectLocationSampleQuerySetSampleQuery(string projectId, string locationId, string sampleQuerySetId, string sampleQueryId) =>
            new SampleQueryName(ResourceNameType.ProjectLocationSampleQuerySetSampleQuery, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sampleQuerySetId: gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)), sampleQueryId: gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQueryId, nameof(sampleQueryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SampleQueryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQuerySetId">The <c>SampleQuerySet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQueryId">The <c>SampleQuery</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SampleQueryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string sampleQuerySetId, string sampleQueryId) =>
            FormatProjectLocationSampleQuerySetSampleQuery(projectId, locationId, sampleQuerySetId, sampleQueryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SampleQueryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQuerySetId">The <c>SampleQuerySet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQueryId">The <c>SampleQuery</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SampleQueryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSampleQuerySetSampleQuery(string projectId, string locationId, string sampleQuerySetId, string sampleQueryId) =>
            s_projectLocationSampleQuerySetSampleQuery.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQueryId, nameof(sampleQueryId)));

        /// <summary>Parses the given resource name string into a new <see cref="SampleQueryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sampleQueryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SampleQueryName"/> if successful.</returns>
        public static SampleQueryName Parse(string sampleQueryName) => Parse(sampleQueryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SampleQueryName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sampleQueryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SampleQueryName"/> if successful.</returns>
        public static SampleQueryName Parse(string sampleQueryName, bool allowUnparsed) =>
            TryParse(sampleQueryName, allowUnparsed, out SampleQueryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SampleQueryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sampleQueryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SampleQueryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sampleQueryName, out SampleQueryName result) =>
            TryParse(sampleQueryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SampleQueryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sampleQueryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SampleQueryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sampleQueryName, bool allowUnparsed, out SampleQueryName result)
        {
            gax::GaxPreconditions.CheckNotNull(sampleQueryName, nameof(sampleQueryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSampleQuerySetSampleQuery.TryParseName(sampleQueryName, out resourceName))
            {
                result = FromProjectLocationSampleQuerySetSampleQuery(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sampleQueryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SampleQueryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sampleQueryId = null, string sampleQuerySetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SampleQueryId = sampleQueryId;
            SampleQuerySetId = sampleQuerySetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SampleQueryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQuerySetId">The <c>SampleQuerySet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sampleQueryId">The <c>SampleQuery</c> ID. Must not be <c>null</c> or empty.</param>
        public SampleQueryName(string projectId, string locationId, string sampleQuerySetId, string sampleQueryId) : this(ResourceNameType.ProjectLocationSampleQuerySetSampleQuery, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sampleQuerySetId: gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)), sampleQueryId: gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQueryId, nameof(sampleQueryId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>SampleQuery</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SampleQueryId { get; }

        /// <summary>
        /// The <c>SampleQuerySet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SampleQuerySetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSampleQuerySetSampleQuery: return s_projectLocationSampleQuerySetSampleQuery.Expand(ProjectId, LocationId, SampleQuerySetId, SampleQueryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SampleQueryName);

        /// <inheritdoc/>
        public bool Equals(SampleQueryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SampleQueryName a, SampleQueryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SampleQueryName a, SampleQueryName b) => !(a == b);
    }

    public partial class SampleQuery
    {
        /// <summary>
        /// <see cref="gcdv::SampleQueryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SampleQueryName SampleQueryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SampleQueryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
