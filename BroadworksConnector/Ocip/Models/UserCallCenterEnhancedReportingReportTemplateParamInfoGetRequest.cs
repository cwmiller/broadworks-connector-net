using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6738""}]")]
    public class UserCallCenterEnhancedReportingReportTemplateParamInfoGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.CallCenterReportTemplateKey _reportTemplate;

        [XmlElement(ElementName = "reportTemplate", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6738")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportTemplateKey ReportTemplate
        {
            get => _reportTemplate;
            set
            {
                ReportTemplateSpecified = true;
                _reportTemplate = value;
            }
        }

        [XmlIgnore]
        public bool ReportTemplateSpecified { get; set; }

    }
}
