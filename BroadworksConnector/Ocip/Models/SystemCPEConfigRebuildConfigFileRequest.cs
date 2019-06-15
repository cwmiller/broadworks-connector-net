using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Rebuild the system default config file for the specified device type.
    /// If the device type is not specified, all files for all device types in the system are rebuilt.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigRebuildConfigFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
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
        
        private BroadWorksConnector.Ocip.Models.CPEDeviceConfigRebuildType _rebuildType;

        [XmlElement(ElementName = "rebuildType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceConfigRebuildType RebuildType {
            get => _rebuildType;
            set {
                RebuildTypeSpecified = true;
                _rebuildType = value;
            }
        }

        [XmlIgnore]
        public bool RebuildTypeSpecified { get; set; }
        
        private bool _force;

        [XmlElement(ElementName = "force", IsNullable = false, Namespace = "")]
        public bool Force {
            get => _force;
            set {
                ForceSpecified = true;
                _force = value;
            }
        }

        [XmlIgnore]
        public bool ForceSpecified { get; set; }
        
    }
}
