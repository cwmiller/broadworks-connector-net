using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a zone.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced by: SystemZoneAddRequest
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemZoneAddRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemZoneCallingRestrictionsZoneAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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

        [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
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
