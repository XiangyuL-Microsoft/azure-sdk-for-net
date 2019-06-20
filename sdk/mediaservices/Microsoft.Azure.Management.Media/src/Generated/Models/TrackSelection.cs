// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class to select a track
    /// </summary>
    public partial class TrackSelection
    {
        /// <summary>
        /// Initializes a new instance of the TrackSelection class.
        /// </summary>
        public TrackSelection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrackSelection class.
        /// </summary>
        /// <param name="trackSelections">TrackSelections is a track property
        /// condition list which can specify track(s)</param>
        public TrackSelection(IList<TrackPropertyCondition> trackSelections = default(IList<TrackPropertyCondition>))
        {
            TrackSelections = trackSelections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets trackSelections is a track property condition list
        /// which can specify track(s)
        /// </summary>
        [JsonProperty(PropertyName = "trackSelections")]
        public IList<TrackPropertyCondition> TrackSelections { get; set; }

    }
}