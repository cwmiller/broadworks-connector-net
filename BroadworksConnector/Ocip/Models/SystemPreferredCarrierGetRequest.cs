using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the attributes of carrier.
    /// The response is either a SystemPreferredCarrierGetResponse or an ErrorResponse.
        /// <see cref="SystemPreferredCarrierGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPreferredCarrierGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
