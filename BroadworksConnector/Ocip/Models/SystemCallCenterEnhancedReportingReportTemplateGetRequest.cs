using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a system level call center report template.
    /// The response is either a SystemCallCenterEnhancedReportingReportTemplateGetResponse or an ErrorResponse.
    /// <see cref="SystemCallCenterEnhancedReportingReportTemplateGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6176""}]")]
    public class SystemCallCenterEnhancedReportingReportTemplateGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterEnhancedReportingReportTemplateGetResponse>
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6176")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

    }
}
