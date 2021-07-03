using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest.
    /// Contains a table with column headings: "Schedule Name", "Created By", "Created By Supervisor",
    /// and "Is Active".
    /// The "Created By" can be either "Administrator" or user id if created by supervisor.
    /// <see cref="GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:3791""}]")]
    public class GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _scheduleReportTable;

        [XmlElement(ElementName = "scheduleReportTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3791")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ScheduleReportTable
        {
            get => _scheduleReportTable;
            set
            {
                ScheduleReportTableSpecified = true;
                _scheduleReportTable = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleReportTableSpecified { get; set; }

    }
}
