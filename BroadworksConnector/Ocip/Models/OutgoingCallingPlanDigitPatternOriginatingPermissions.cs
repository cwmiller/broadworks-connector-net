using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan originating call permissions for specified digit patterns.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1944""}]")]
    public class OutgoingCallingPlanDigitPatternOriginatingPermissions
    {

        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternOriginatingPermission> _digitPatternPermissions = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternOriginatingPermission>();

        [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1944")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternOriginatingPermission> DigitPatternPermissions
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
