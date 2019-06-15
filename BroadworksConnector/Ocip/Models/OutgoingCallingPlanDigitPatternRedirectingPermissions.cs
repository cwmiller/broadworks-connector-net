using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan redirecting call permissions for specified digit patterns.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class OutgoingCallingPlanDigitPatternRedirectingPermissions 
    {

        
        private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermission> _digitPatternPermissions;

        [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermission> DigitPatternPermissions {
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
