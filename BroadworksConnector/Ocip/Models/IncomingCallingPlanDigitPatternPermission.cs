using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Indicates whether calls from specified digit patterns are permitted.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""22e19489d2787693c01f531be4452169:184""}]")]
    public class IncomingCallingPlanDigitPatternPermission
    {

        protected string _digitPatternName;

        [XmlElement(ElementName = "digitPatternName", IsNullable = false, Namespace = "")]
        [Group(@"22e19489d2787693c01f531be4452169:184")]
        [MinLength(1)]
        [MaxLength(30)]
        public string DigitPatternName
        {
            get => _digitPatternName;
            set
            {
                DigitPatternNameSpecified = true;
                _digitPatternName = value;
            }
        }

        [XmlIgnore]
        protected bool DigitPatternNameSpecified { get; set; }

        protected bool _allow;

        [XmlElement(ElementName = "allow", IsNullable = false, Namespace = "")]
        [Group(@"22e19489d2787693c01f531be4452169:184")]
        public bool Allow
        {
            get => _allow;
            set
            {
                AllowSpecified = true;
                _allow = value;
            }
        }

        [XmlIgnore]
        protected bool AllowSpecified { get; set; }

    }
}
