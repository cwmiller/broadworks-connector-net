using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterEnhancedReportingScheduledReportGetCompletedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _scheduledReportTable;

        [XmlElement(ElementName = "scheduledReportTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable ScheduledReportTable
        {
            get => _scheduledReportTable;
            set
            {
                ScheduledReportTableSpecified = true;
                _scheduledReportTable = value;
            }
        }

        [XmlIgnore]
        public bool ScheduledReportTableSpecified { get; set; }
    }
}
