using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a group device profile file.
    /// The response is either GroupAccessDeviceFileGetResponse or ErrorResponse.
    /// Replaced By: GroupAccessDeviceFileGetRequest14sp8
        /// <see cref="GroupAccessDeviceFileGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupAccessDeviceFileGetRequest14sp8"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAccessDeviceFileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
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
