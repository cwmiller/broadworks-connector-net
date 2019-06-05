using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterEnhancedReportingGetResponse19 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.CallCenterReportServerChoice19 _reportingServer;

        [XmlElement(ElementName = "reportingServer", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportServerChoice19 ReportingServer
        {
            get => _reportingServer;
            set
            {
                ReportingServerSpecified = true;
                _reportingServer = value;
            }
        }

        [XmlIgnore]
        public bool ReportingServerSpecified { get; set; }
    }
}
