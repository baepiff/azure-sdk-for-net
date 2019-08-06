// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The schedule according to which Jobs will be created
    /// </summary>
    public partial class Schedule
    {
        /// <summary>
        /// Initializes a new instance of the Schedule class.
        /// </summary>
        public Schedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Schedule class.
        /// </summary>
        /// <param name="doNotRunUntil">The earliest time at which any Job may
        /// be created under this Job Schedule.</param>
        /// <param name="doNotRunAfter">A time after which no Job will be
        /// created under this Job Schedule. The schedule will move to the
        /// completed state as soon as this deadline is past and there is no
        /// active Job under this Job Schedule.</param>
        /// <param name="startWindow">The time interval, starting from the time
        /// at which the schedule indicates a Job should be created, within
        /// which a Job must be created.</param>
        /// <param name="recurrenceInterval">The time interval between the
        /// start times of two successive Jobs under the Job Schedule. A Job
        /// Schedule can have at most one active Job under it at any given
        /// time.</param>
        public Schedule(System.DateTime? doNotRunUntil = default(System.DateTime?), System.DateTime? doNotRunAfter = default(System.DateTime?), System.TimeSpan? startWindow = default(System.TimeSpan?), System.TimeSpan? recurrenceInterval = default(System.TimeSpan?))
        {
            DoNotRunUntil = doNotRunUntil;
            DoNotRunAfter = doNotRunAfter;
            StartWindow = startWindow;
            RecurrenceInterval = recurrenceInterval;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the earliest time at which any Job may be created
        /// under this Job Schedule.
        /// </summary>
        /// <remarks>
        /// If you do not specify a doNotRunUntil time, the schedule becomes
        /// ready to create Jobs immediately.
        /// </remarks>
        [JsonProperty(PropertyName = "doNotRunUntil")]
        public System.DateTime? DoNotRunUntil { get; set; }

        /// <summary>
        /// Gets or sets a time after which no Job will be created under this
        /// Job Schedule. The schedule will move to the completed state as soon
        /// as this deadline is past and there is no active Job under this Job
        /// Schedule.
        /// </summary>
        /// <remarks>
        /// If you do not specify a doNotRunAfter time, and you are creating a
        /// recurring Job Schedule, the Job Schedule will remain active until
        /// you explicitly terminate it.
        /// </remarks>
        [JsonProperty(PropertyName = "doNotRunAfter")]
        public System.DateTime? DoNotRunAfter { get; set; }

        /// <summary>
        /// Gets or sets the time interval, starting from the time at which the
        /// schedule indicates a Job should be created, within which a Job must
        /// be created.
        /// </summary>
        /// <remarks>
        /// If a Job is not created within the startWindow interval, then the
        /// 'opportunity' is lost; no Job will be created until the next
        /// recurrence of the schedule. If the schedule is recurring, and the
        /// startWindow is longer than the recurrence interval, then this is
        /// equivalent to an infinite startWindow, because the Job that is
        /// 'due' in one recurrenceInterval is not carried forward into the
        /// next recurrence interval. The default is infinite. The minimum
        /// value is 1 minute. If you specify a lower value, the Batch service
        /// rejects the schedule with an error; if you are calling the REST API
        /// directly, the HTTP status code is 400 (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "startWindow")]
        public System.TimeSpan? StartWindow { get; set; }

        /// <summary>
        /// Gets or sets the time interval between the start times of two
        /// successive Jobs under the Job Schedule. A Job Schedule can have at
        /// most one active Job under it at any given time.
        /// </summary>
        /// <remarks>
        /// Because a Job Schedule can have at most one active Job under it at
        /// any given time, if it is time to create a new Job under a Job
        /// Schedule, but the previous Job is still running, the Batch service
        /// will not create the new Job until the previous Job finishes. If the
        /// previous Job does not finish within the startWindow period of the
        /// new recurrenceInterval, then no new Job will be scheduled for that
        /// interval. For recurring Jobs, you should normally specify a
        /// jobManagerTask in the jobSpecification. If you do not use
        /// jobManagerTask, you will need an external process to monitor when
        /// Jobs are created, add Tasks to the Jobs and terminate the Jobs
        /// ready for the next recurrence. The default is that the schedule
        /// does not recur: one Job is created, within the startWindow after
        /// the doNotRunUntil time, and the schedule is complete as soon as
        /// that Job finishes. The minimum value is 1 minute. If you specify a
        /// lower value, the Batch service rejects the schedule with an error;
        /// if you are calling the REST API directly, the HTTP status code is
        /// 400 (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "recurrenceInterval")]
        public System.TimeSpan? RecurrenceInterval { get; set; }

    }
}
