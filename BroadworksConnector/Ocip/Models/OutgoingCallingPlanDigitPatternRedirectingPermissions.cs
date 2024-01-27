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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:1992""}]")]
    public class OutgoingCallingPlanDigitPatternRedirectingPermissions
    {

        protected List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermission> _digitPatternPermissions = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermission>();

        [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1992")]
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
        protected bool DigitPatternPermissionsSpecified { get; set; }

    }
}
