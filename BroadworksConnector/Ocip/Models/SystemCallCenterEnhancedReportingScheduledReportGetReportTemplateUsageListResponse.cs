using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest.
    /// Contains a table with column headings: "Schedule Name", "Organization Type", "Service Provider Id",
    /// "Group Id", "Created By", "Created By Supervisor", and "Is Active".
    /// The "Organization Type" is either "Service Provider" or "Enterprise".
    /// The "Created By" can be either "Administrator" or user id if created by supervisor.
    /// The possible values for "Created By Supervisor" are "true" and "false".
        /// <see cref="SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _scheduleReportTable;

        [XmlElement(ElementName = "scheduleReportTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ScheduleReportTable {
            get => _scheduleReportTable;
            set {
                ScheduleReportTableSpecified = true;
                _scheduleReportTable = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleReportTableSpecified { get; set; }
        
    }
}
