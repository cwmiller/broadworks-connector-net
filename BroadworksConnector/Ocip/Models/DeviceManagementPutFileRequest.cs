using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Informs BroadWorks that a file was uploaded to the repository. The response is always a SuccessResponse.
        /// <see cref="SuccessResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class DeviceManagementPutFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _deviceAccessURI;

        [XmlElement(ElementName = "deviceAccessURI", IsNullable = false, Namespace = "")]
        public string DeviceAccessURI {
            get => _deviceAccessURI;
            set {
                DeviceAccessURISpecified = true;
                _deviceAccessURI = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessURISpecified { get; set; }
        
        private string _ipAddress;

        [XmlElement(ElementName = "ipAddress", IsNullable = false, Namespace = "")]
        public string IpAddress {
            get => _ipAddress;
            set {
                IpAddressSpecified = true;
                _ipAddress = value;
            }
        }

        [XmlIgnore]
        public bool IpAddressSpecified { get; set; }
        
    }
}
