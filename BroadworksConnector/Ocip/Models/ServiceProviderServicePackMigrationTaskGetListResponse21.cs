using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServicePackMigrationTaskGetListRequest21.
    /// Contains a table with  a row for each service pack migration task and column headings :
    /// "Start Timestamp Milliseconds", "Name", "Status", "Error Count", "Users Processed", "Users Total".
    /// The start timestamp column is the number of milliseconds since the standard base time known as "the epoch",
    /// namely January 1, 1970, 00:00:00 GMT. The status column is the task status which can be Awaiting edit, Pending,
    /// Processing, Terminating, Terminated, Stopped by system, Completed, or Expired.
    /// <see cref="ServiceProviderServicePackMigrationTaskGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6367""}]")]
    public class ServiceProviderServicePackMigrationTaskGetListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _taskTable;

        [XmlElement(ElementName = "taskTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6367")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TaskTable
        {
            get => _taskTable;
            set
            {
                TaskTableSpecified = true;
                _taskTable = value;
            }
        }

        [XmlIgnore]
        protected bool TaskTableSpecified { get; set; }

    }
}
