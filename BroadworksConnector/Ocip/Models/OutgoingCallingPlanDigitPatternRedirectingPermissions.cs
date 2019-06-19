using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan redirecting call permissions for specified digit patterns.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1992""}]")]
    public class OutgoingCallingPlanDigitPatternRedirectingPermissions
    {

        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermission> _digitPatternPermissions = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermission>();

        [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1992")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermission> DigitPatternPermissions
        {
            get => _digitPatternPermissions;
            set
            {
                DigitPatternPermissionsSpecified = true;
                _digitPatternPermissions = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternPermissionsSpecified { get; set; }

    }
}
