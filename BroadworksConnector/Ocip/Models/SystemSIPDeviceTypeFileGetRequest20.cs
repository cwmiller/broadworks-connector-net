using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a sip device type file.
    /// The response is either SystemSIPDeviceTypeFileGetResponse20 or ErrorResponse.
    /// 
    /// Replaced by: SystemSIPDeviceTypeFileGetRequest20Sp1
        /// <see cref="SystemSIPDeviceTypeFileGetResponse20"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSIPDeviceTypeFileGetRequest20Sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeviceTypeFileGetRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        public string DeviceType {
            get => _deviceType;
            set {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }
        
        private string _fileFormat;

        [XmlElement(ElementName = "fileFormat", IsNullable = false, Namespace = "")]
        public string FileFormat {
            get => _fileFormat;
            set {
                FileFormatSpecified = true;
                _fileFormat = value;
            }
        }

        [XmlIgnore]
        public bool FileFormatSpecified { get; set; }
        
    }
}
