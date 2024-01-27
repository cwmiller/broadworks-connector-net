using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Indicates whether originating calls using specified digit patterns are permitted.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:1932""}]")]
    public class OutgoingCallingPlanDigitPatternOriginatingPermission
    {

        protected string _digitPatternName;

        [XmlElement(ElementName = "digitPatternName", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1932")]
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

        protected BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission _permission;

        [XmlElement(ElementName = "permission", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1932")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanOriginatingPermission Permission
        {
            get => _permission;
            set
            {
                PermissionSpecified = true;
                _permission = value;
            }
        }

        [XmlIgnore]
        protected bool PermissionSpecified { get; set; }

    }
}
