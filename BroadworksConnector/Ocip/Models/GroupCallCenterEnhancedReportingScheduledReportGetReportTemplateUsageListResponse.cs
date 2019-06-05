using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _scheduleReportTable;

        [XmlElement(ElementName = "scheduleReportTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable ScheduleReportTable
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
