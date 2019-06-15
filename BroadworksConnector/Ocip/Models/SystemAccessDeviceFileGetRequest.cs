using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a device profile file.
    /// The response is either SystemAccessDeviceFileGetResponse or ErrorResponse.
    /// Replaced By: SystemAccessDeviceFileGetRequest14sp8
        /// <see cref="SystemAccessDeviceFileGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemAccessDeviceFileGetRequest14sp8"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceFileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        public string DeviceName {
            get => _deviceName;
            set {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceNameSpecified { get; set; }
        
        private string _fileType;

        [XmlElement(ElementName = "fileType", IsNullable = false, Namespace = "")]
        public string FileType {
            get => _fileType;
            set {
                FileTypeSpecified = true;
                _fileType = value;
            }
        }

        [XmlIgnore]
        public bool FileTypeSpecified { get; set; }
        
    }
}
