using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceTypeGetAvailableListRequest22.
    /// 
    /// Note: element numberOfPorts is only used by devices types with static line ordering enabled
    /// <see cref="SystemDeviceTypeGetAvailableListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7680""}]")]
    public class SystemDeviceTypeGetAvailableListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _deviceType = new List<string>();

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7680")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse22TypeInfo> _typeInfo = new List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse22TypeInfo>();

        [XmlElement(ElementName = "typeInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7680")]
        public List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse22TypeInfo> TypeInfo
        {
            get => _typeInfo;
            set
            {
                TypeInfoSpecified = true;
                _typeInfo = value;
            }
        }

        [XmlIgnore]
        protected bool TypeInfoSpecified { get; set; }

    }
}
