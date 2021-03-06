﻿using System;
using Nop.Core.Domain.Customers;
using MongoDB.Bson.Serialization.Attributes;

namespace Nop.Core.Domain.Logging
{
    /// <summary>
    /// Represents an activity log record
    /// </summary>
    [BsonIgnoreExtraElements]
    public partial class ActivityLog : BaseEntity
    {
        /// <summary>
        /// Gets or sets the activity log type identifier
        /// </summary>
        public int ActivityLogTypeId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the entity key identifier
        /// </summary>
        public int EntityKeyId { get; set; }
        /// <summary>
        /// Gets or sets the activity comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets the activity log type
        /// </summary>
        public virtual ActivityLogType ActivityLogType { get; set; }

    }

    /// <summary>
    /// Represents an activity stats record - Auxiliary class to reports
    /// </summary>
    public class ActivityStats
    {
        public int ActivityLogTypeId { get; set; }
        public int EntityKeyId { get; set; }
        public int Count { get; set; }
    }

}
