using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Pinhole Digit Plan Call Me Now call permissions for specified digit patterns.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class OutgoingPinholeDigitPlanDigitPatternCallMeNowPermissions 
    {

        
        private List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowPermission> _digitPatternPermissions;

        [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternCallMeNowPermission> DigitPatternPermissions {
            get => _digitPatternPermissions;
            set {
                DigitPatternPermissionsSpecified = true;
                _digitPatternPermissions = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternPermissionsSpecified { get; set; }
        
    }
}
