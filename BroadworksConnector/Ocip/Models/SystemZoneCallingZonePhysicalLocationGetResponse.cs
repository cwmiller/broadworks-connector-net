using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemZoneCallingZonePhysicalLocationGetRequest.
        /// <see cref="SystemZoneCallingZonePhysicalLocationGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemZoneCallingZonePhysicalLocationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
