using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Uniquely identifies a call center report template created in the system.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:1085""}]")]
    public class CallCenterReportTemplateKey
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterReportTemplateLevel _templateLevel;

        [XmlElement(ElementName = "templateLevel", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1085")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportTemplateLevel TemplateLevel
        {
            get => _templateLevel;
            set
            {
                TemplateLevelSpecified = true;
                _templateLevel = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateLevelSpecified { get; set; }

        protected string _templateName;

        [XmlElement(ElementName = "templateName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1085")]
        [MinLength(1)]
        [MaxLength(80)]
        public string TemplateName
        {
            get => _templateName;
            set
            {
                TemplateNameSpecified = true;
                _templateName = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateNameSpecified { get; set; }

    }
}
