using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the input parameter info for a call center report template.
    /// The response is either a UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse or an ErrorResponse.
        /// <see cref="UserCallCenterEnhancedReportingReportTemplateParamInfoGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.CallCenterReportTemplateKey _reportTemplate;

        [XmlElement(ElementName = "reportTemplate", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportTemplateKey ReportTemplate {
            get => _reportTemplate;
            set {
                ReportTemplateSpecified = true;
                _reportTemplate = value;
            }
        }

        [XmlIgnore]
        public bool ReportTemplateSpecified { get; set; }
        
    }
}
