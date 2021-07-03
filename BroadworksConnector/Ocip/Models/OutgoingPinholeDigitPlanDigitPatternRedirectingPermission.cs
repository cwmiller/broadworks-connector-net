using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Indicates whether redirecting calls using specified Pinhole digit patterns are permitted.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:2355""}]")]
    public class OutgoingPinholeDigitPlanDigitPatternRedirectingPermission
    {

        private string _digitPatternName;

        [XmlElement(ElementName = "digitPatternName", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2355")]
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

        private BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanRedirectingPermission _permission;

        [XmlElement(ElementName = "permission", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2355")]
        public BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanRedirectingPermission Permission
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
