using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan Call Me Now call permissions for specified digit patterns.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:1896""}]")]
    public class OutgoingCallingPlanDigitPatternCallMeNowPermissions
    {

        protected List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowPermission> _digitPatternPermissions = new List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowPermission>();

        [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1896")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowPermission> DigitPatternPermissions
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
