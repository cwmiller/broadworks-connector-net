using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallCenterEnhancedReportingScheduledReportGetListRequest.
    /// Contains a table with column headings : "Schedule Name", "Description", "Created By",
    /// "Is Supervisor Report", "Status", "Report Template Name", "Report Template Level" and "Recurring".
    /// The "Created By" can be either "Administrator" or user id if created by supervisor.
    /// The possible values for "Status" are "Active", and "Completed".
    /// The possible values for "Recurring" are "None", "Daily", "Weekly", "Monthly" and "Yearly".
    /// The possible values for "Report Template Level" are "System" and "Group".
    /// <see cref="GroupCallCenterEnhancedReportingScheduledReportGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:3755""}]")]
    public class GroupCallCenterEnhancedReportingScheduledReportGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _scheduledReportTable;

        [XmlElement(ElementName = "scheduledReportTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3755")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ScheduledReportTable
        {
            get => _scheduledReportTable;
            set
            {
                ScheduledReportTableSpecified = true;
                _scheduledReportTable = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduledReportTableSpecified { get; set; }

    }
}
