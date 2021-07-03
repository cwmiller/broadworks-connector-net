using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallCenterEnhancedReportingGetRequest19.
    /// <see cref="GroupCallCenterEnhancedReportingGetRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:3395""}]")]
    public class GroupCallCenterEnhancedReportingGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice19 _reportingServer;

        [XmlElement(ElementName = "reportingServer", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3395")]
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
        protected bool ReportingServerSpecified { get; set; }

    }
}
