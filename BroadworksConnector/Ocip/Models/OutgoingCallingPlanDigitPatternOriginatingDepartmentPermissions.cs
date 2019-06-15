using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan originating call permissions for specified digit patterns.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class OutgoingCallingPlanDigitPatternOriginatingDepartmentPermissions 
    {

        
        private BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DepartmentKey DepartmentKey {
            get => _departmentKey;
            set {
                DepartmentKeySpecified = true;
                _departmentKey = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentKeySpecified { get; set; }
        
        private string _departmentName;

        [XmlElement(ElementName = "departmentName", IsNullable = false, Namespace = "")]
        public string DepartmentName {
            get => _departmentName;
            set {
                DepartmentNameSpecified = true;
                _departmentName = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternOriginatingPermissions _digitPatternPermissions;

        [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternOriginatingPermissions DigitPatternPermissions {
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
