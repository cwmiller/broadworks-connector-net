using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AccessDevice
    {
        private BroadworksConnector.Ocip.Models.AccessDeviceLevel _deviceLevel;

        [XmlElement(ElementName = "deviceLevel", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel
        {
            get => _deviceLevel;
            set
            {
                DeviceLevelSpecified = true;
                _deviceLevel = value;
            }
        }

        [XmlIgnore]
        public bool DeviceLevelSpecified { get; set; }
        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        public string DeviceName
        {
            get => _deviceName;
            set
            {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceNameSpecified { get; set; }
    }
}
