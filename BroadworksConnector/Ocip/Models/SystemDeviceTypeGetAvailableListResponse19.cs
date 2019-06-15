using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceTypeGetAvailableListRequest19.
    /// Note: element numberOfPorts is only used by devices types with static line ordering enabled
    /// Replaced by SystemDeviceTypeGetAvailableListResponse22 in AS data mode.
        /// <see cref="SystemDeviceTypeGetAvailableListRequest19"/>
        /// <see cref="SystemDeviceTypeGetAvailableListResponse22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceTypeGetAvailableListResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        public List<string> DeviceType {
            get => _deviceType;
            set {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse19TypeInfo> _typeInfo;

        [XmlElement(ElementName = "typeInfo", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse19TypeInfo> TypeInfo {
            get => _typeInfo;
            set {
                TypeInfoSpecified = true;
                _typeInfo = value;
            }
        }

        [XmlIgnore]
        public bool TypeInfoSpecified { get; set; }
        
    }
}
