using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample.Repositary.Model
{

    public enum WorkflowStatus
    {
        New,
        Approved,
        Reproved
    }

    public abstract class ModelBase
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [ReadOnly(true)]
        public int Id { get; set; }

        /// <summary>
        /// Optimistic Concurrency and dataflow control
        /// </summary>
        [ScaffoldColumn(false)]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// Date and time of data creation
        /// </summary>
        [ReadOnly(true)]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// New, Approved or Reproved
        /// </summary>
        [ReadOnly(true)]
        public WorkflowStatus? Status { get; set; }

        /// <summary>
        /// Logged user that created the information
        /// </summary>
        [ScaffoldColumn(false)]
        public int CreateUserId { get; set; }

        /// <summary>
        /// Date and time of last data update
        /// </summary>
        [ScaffoldColumn(false)]
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Logged user that changed the information to the current value
        /// </summary>
        [ScaffoldColumn(false)]
        public int? UpdateUserId { get; set; }
    }
}