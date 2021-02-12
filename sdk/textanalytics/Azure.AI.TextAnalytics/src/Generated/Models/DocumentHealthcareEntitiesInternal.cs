// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics.Models;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The DocumentHealthcareEntities. </summary>
    internal partial class DocumentHealthcareEntitiesInternal
    {
        /// <summary> Initializes a new instance of DocumentHealthcareEntitiesInternal. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="entities"/>, <paramref name="relations"/>, or <paramref name="warnings"/> is null. </exception>
        internal DocumentHealthcareEntitiesInternal(string id, IEnumerable<HealthcareEntityInternal> entities, IEnumerable<HealthcareRelationInternal> relations, IEnumerable<TextAnalyticsWarningInternal> warnings)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }
            if (relations == null)
            {
                throw new ArgumentNullException(nameof(relations));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }

            Id = id;
            Entities = entities.ToList();
            Relations = relations.ToList();
            Warnings = warnings.ToList();
        }

        /// <summary> Initializes a new instance of DocumentHealthcareEntitiesInternal. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="entities"> Healthcare entities. </param>
        /// <param name="relations"> Healthcare entity relations. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        internal DocumentHealthcareEntitiesInternal(string id, IReadOnlyList<HealthcareEntityInternal> entities, IReadOnlyList<HealthcareRelationInternal> relations, IReadOnlyList<TextAnalyticsWarningInternal> warnings, TextDocumentStatistics? statistics)
        {
            Id = id;
            Entities = entities;
            Relations = relations;
            Warnings = warnings;
            Statistics = statistics;
        }
    }
}
