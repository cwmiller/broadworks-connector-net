using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceTypeGetAvailableListRequest.
        /// <see cref="SystemDeviceTypeGetAvailableListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceTypeGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponseTypeInfo> _typeInfo;

        [XmlElement(ElementName = "typeInfo", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponseTypeInfo> TypeInfo {
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
