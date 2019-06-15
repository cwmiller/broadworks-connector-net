using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies attributes of a zone in the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced by: SystemZonePhysicalLocationAddListRequest and
    /// SystemZonePhysicalLocationDeleteListRequest
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemZonePhysicalLocationAddListRequest"/>
        /// <see cref="SystemZonePhysicalLocationDeleteListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemZoneCallingRestrictionsZoneModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        public string ZoneName {
            get => _zoneName;
            set {
                ZoneNameSpecified = true;
                _zoneName = value;
            }
        }

        [XmlIgnore]
        public bool ZoneNameSpecified { get; set; }
        
        private string _physicalLocation;

        [XmlElement(ElementName = "physicalLocation", IsNullable = true, Namespace = "")]
        public string PhysicalLocation {
            get => _physicalLocation;
            set {
                PhysicalLocationSpecified = true;
                _physicalLocation = value;
            }
        }

        [XmlIgnore]
        public bool PhysicalLocationSpecified { get; set; }
        
    }
}
