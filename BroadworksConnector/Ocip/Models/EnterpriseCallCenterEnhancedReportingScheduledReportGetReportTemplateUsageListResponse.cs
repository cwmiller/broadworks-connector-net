using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest.
    /// Contains a table with column headings: "Schedule Name", "Created By", "Created By Supervisor", and
    /// "Is Active".
    /// The "Created By" can be either "Administrator" or user id if created by supervisor.
    /// <see cref="EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1692""}]")]
    public class EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _scheduleReportTable;

        [XmlElement(ElementName = "scheduleReportTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1692")]
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
        public bool ScheduleReportTableSpecified { get; set; }

    }
}
