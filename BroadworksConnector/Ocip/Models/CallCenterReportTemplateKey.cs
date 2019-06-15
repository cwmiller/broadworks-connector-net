using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Uniquely identifies a call center report template created in the system.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterReportTemplateKey 
    {

        
        private BroadWorksConnector.Ocip.Models.CallCenterReportTemplateLevel _templateLevel;

        [XmlElement(ElementName = "templateLevel", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportTemplateLevel TemplateLevel {
            get => _templateLevel;
            set {
                TemplateLevelSpecified = true;
                _templateLevel = value;
            }
        }

        [XmlIgnore]
        public bool TemplateLevelSpecified { get; set; }
        
        private string _templateName;

        [XmlElement(ElementName = "templateName", IsNullable = false, Namespace = "")]
        public string TemplateName {
            get => _templateName;
            set {
                TemplateNameSpecified = true;
                _templateName = value;
            }
        }

        [XmlIgnore]
        public bool TemplateNameSpecified { get; set; }
        
    }
}
