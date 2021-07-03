using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceTypeGetAvailableListRequest14sp3.
    /// <see cref="SystemDeviceTypeGetAvailableListRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:25908""}]")]
    public class SystemDeviceTypeGetAvailableListResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _deviceType = new List<string>();

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25908")]
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

        private List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse14sp3TypeInfo> _typeInfo = new List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse14sp3TypeInfo>();

        [XmlElement(ElementName = "typeInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25908")]
        public List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse14sp3TypeInfo> TypeInfo
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
