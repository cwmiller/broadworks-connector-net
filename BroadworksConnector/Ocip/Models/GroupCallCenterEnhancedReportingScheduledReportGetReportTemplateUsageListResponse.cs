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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:3786""}]")]
    public class GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _scheduleReportTable;

        [XmlElement(ElementName = "scheduleReportTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3786")]
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
