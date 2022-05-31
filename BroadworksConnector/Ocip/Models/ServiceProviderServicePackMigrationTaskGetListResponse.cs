using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServicePackMigrationTaskGetListRequest.
    /// Contains a table with  a row for each service pack migration task and column headings :
    /// "Start Timestamp Milliseconds", "Name", "Status", "Error Count", "Users Processed", "Users Total".
    /// The start timestamp column is the number of milliseconds since the standard base time known as "the epoch",
    /// namely January 1, 1970, 00:00:00 GMT.
    /// 
    /// Replaced By : ServiceProviderServicePackMigrationTaskGetListResponse21 in AS data mode
    /// <see cref="ServiceProviderServicePackMigrationTaskGetListRequest"/>
    /// <see cref="ServiceProviderServicePackMigrationTaskGetListResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:6253""}]")]
    public class ServiceProviderServicePackMigrationTaskGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _taskTable;

        [XmlElement(ElementName = "taskTable", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:6253")]
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
