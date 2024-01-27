using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9932""}]")]
    public class SystemDeviceTypeGetAvailableListResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _deviceType = new List<string>();

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9932")]
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

        protected List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse19TypeInfo> _typeInfo = new List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse19TypeInfo>();

        [XmlElement(ElementName = "typeInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9932")]
        public List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse19TypeInfo> TypeInfo
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
