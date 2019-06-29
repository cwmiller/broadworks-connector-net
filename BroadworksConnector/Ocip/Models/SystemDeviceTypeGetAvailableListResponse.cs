using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceTypeGetAvailableListRequest.
    /// <see cref="SystemDeviceTypeGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4977""}]")]
    public class SystemDeviceTypeGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _deviceType = new List<string>();

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4977")]
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

        private List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponseTypeInfo> _typeInfo = new List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponseTypeInfo>();

        [XmlElement(ElementName = "typeInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4977")]
        public List<BroadWorksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponseTypeInfo> TypeInfo
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
