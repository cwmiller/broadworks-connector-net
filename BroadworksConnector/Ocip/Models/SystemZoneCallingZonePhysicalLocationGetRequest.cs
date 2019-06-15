using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns a zone calling physical location for a given zone.
    /// The response is SystemZoneCallingZonePhysicalLocationGetResponse or an ErrorResponse.
        /// <see cref="SystemZoneCallingZonePhysicalLocationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemZoneCallingZonePhysicalLocationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
