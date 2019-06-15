using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a carrier from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// An ErrorResponse is returned if the carrier is in use, or if the carrier didn't exist prior to deletion..
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPreferredCarrierDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
        public string Carrier {
            get => _carrier;
            set {
                CarrierSpecified = true;
                _carrier = value;
            }
        }

        [XmlIgnore]
        public bool CarrierSpecified { get; set; }
        
    }
}
