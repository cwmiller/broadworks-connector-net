using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete an OCI entry in the Broadworks Common Communication Transport (BCCT) protocol to interface
    /// mapping table.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBCCTDeleteOCIInterfaceAddressRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _interfaceNetAddress;

        [XmlElement(ElementName = "interfaceNetAddress", IsNullable = false, Namespace = "")]
        public string InterfaceNetAddress {
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
