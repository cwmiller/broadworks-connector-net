using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBCCTGetOCIInterfaceAddressListRequest.
        /// <see cref="SystemBCCTGetOCIInterfaceAddressListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBCCTGetOCIInterfaceAddressListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _interfaceNetAddress;

        [XmlElement(ElementName = "interfaceNetAddress", IsNullable = false, Namespace = "")]
        public List<string> InterfaceNetAddress {
            get => _interfaceNetAddress;
            set {
                InterfaceNetAddressSpecified = true;
                _interfaceNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool InterfaceNetAddressSpecified { get; set; }
        
    }
}
