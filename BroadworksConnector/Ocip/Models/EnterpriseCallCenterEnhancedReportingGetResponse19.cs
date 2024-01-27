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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:1314""}]")]
    public class EnterpriseCallCenterEnhancedReportingGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice19 _reportingServer;

        [XmlElement(ElementName = "reportingServer", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:1314")]
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
