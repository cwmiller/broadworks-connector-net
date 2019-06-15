using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Indicates whether redirecting calls using specified Pinhole digit patterns are permitted.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class OutgoingPinholeDigitPlanDigitPatternRedirectingPermission 
    {

        
        private string _digitPatternName;

        [XmlElement(ElementName = "digitPatternName", IsNullable = false, Namespace = "")]
        public string DigitPatternName {
            get => _digitPatternName;
            set {
                DigitPatternNameSpecified = true;
                _digitPatternName = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanRedirectingPermission _permission;

        [XmlElement(ElementName = "permission", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanRedirectingPermission Permission {
            get => _permission;
            set {
                PermissionSpecified = true;
                _permission = value;
            }
        }

        [XmlIgnore]
        public bool PermissionSpecified { get; set; }
        
    }
}
