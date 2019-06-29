using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListRequest
    /// Contains a table with column headings : "Schedule Name", "Description", "Created By",
    /// "Is Supervisor Report", "Report Template Name", "Report Template Level" and "Recurring".
    /// The "Created By" can be either "Administrator" or user id if created by supervisor.
    /// The possible values for "Recurring" are "None", "Daily", "Weekly", "Monthly" and "Yearly".
    /// The possible values for "Report Level" are "System" and "Enterprise".
    /// <see cref="EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1616""}]")]
    public class EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _scheduledReportTable;

        [XmlElement(ElementName = "scheduledReportTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1616")]
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
