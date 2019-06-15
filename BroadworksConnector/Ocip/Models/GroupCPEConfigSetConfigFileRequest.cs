using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to set a new group default configuration file for a device type.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// When the element configFile is set to nil, the configuration file defined
    /// at the parent level is used.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCPEConfigSetConfigFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.FileResource _configFile;

        [XmlElement(ElementName = "configFile", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.FileResource ConfigFile {
            get => _configFile;
            set {
                ConfigFileSpecified = true;
                _configFile = value;
            }
        }

        [XmlIgnore]
        public bool ConfigFileSpecified { get; set; }
        
    }
}
