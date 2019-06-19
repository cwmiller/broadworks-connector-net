using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterEnhancedReportingGetRequest19.
    /// <see cref="EnterpriseCallCenterEnhancedReportingGetRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1308""}]")]
    public class EnterpriseCallCenterEnhancedReportingGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice19 _reportingServer;

        [XmlElement(ElementName = "reportingServer", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1308")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice19 ReportingServer
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
