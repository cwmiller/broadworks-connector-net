using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemEmergencyZonesGetRequest.
        /// <see cref="SystemEmergencyZonesGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemEmergencyZonesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        public string DefaultFromAddress {
            get => _defaultFromAddress;
            set {
                DefaultFromAddressSpecified = true;
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool DefaultFromAddressSpecified { get; set; }
        
    }
}
