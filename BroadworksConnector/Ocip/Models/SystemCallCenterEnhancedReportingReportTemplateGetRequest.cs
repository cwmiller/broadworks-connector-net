using System;
using System.Xml.Serialization;
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
     
    public class SystemCallCenterEnhancedReportingReportTemplateGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
    }
}
