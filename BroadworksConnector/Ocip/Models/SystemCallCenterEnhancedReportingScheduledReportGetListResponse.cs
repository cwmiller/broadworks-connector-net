using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEnhancedReportingScheduledReportGetListRequest.
    /// Contains a table with column headings : "Scheduled Report Name", "Description",
    /// "Service Provider Id", "Is Enterprise", "Group Id", "Created By", "Is Supervisor Report",  "Status",
    /// "Report Template Name", "Report Template Level" and "Recurring".
    /// The "Created By" can be either "Administrator" or user id if created by supervisor.
    /// The possible values for "Status" are "Active", and "Completed".
    /// The possible values for "Recurring" are "None", "Daily", "Weekly", "Monthly" and "Yearly".
    /// The possible values for "Report Template Level" are "System", "Enterprise" and "Group".
    /// For the rows with "Is Enterprise" column value "true", the "Group Id" column will be empty.
        /// <see cref="SystemCallCenterEnhancedReportingScheduledReportGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterEnhancedReportingScheduledReportGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _scheduledReportTable;

        [XmlElement(ElementName = "scheduledReportTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ScheduledReportTable {
            get => _scheduledReportTable;
            set {
                ScheduledReportTableSpecified = true;
                _scheduledReportTable = value;
            }
        }

        [XmlIgnore]
        public bool ScheduledReportTableSpecified { get; set; }
        
    }
}
