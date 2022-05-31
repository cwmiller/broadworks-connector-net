using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7129""}]")]
    public class SystemCPEConfigRebuildConfigFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7129")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
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

        protected BroadWorksConnector.Ocip.Models.CPEDeviceConfigRebuildType _rebuildType;

        [XmlElement(ElementName = "rebuildType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7129")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceConfigRebuildType RebuildType
        {
            get => _rebuildType;
            set
            {
                RebuildTypeSpecified = true;
                _rebuildType = value;
            }
        }

        [XmlIgnore]
        protected bool RebuildTypeSpecified { get; set; }

        protected bool _force;

        [XmlElement(ElementName = "force", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7129")]
        public bool Force
        {
            get => _force;
            set
            {
                ForceSpecified = true;
                _force = value;
            }
        }

        [XmlIgnore]
        protected bool ForceSpecified { get; set; }

    }
}
