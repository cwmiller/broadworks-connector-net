using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to set a new system default configuration file for a device type.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6879""}]")]
    public class SystemCPEConfigSetConfigFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6879")]
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
        public bool DeviceTypeSpecified { get; set; }

        private string _configFile;

        [XmlElement(ElementName = "configFile", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6879")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ConfigFile
        {
            get => _configFile;
            set
            {
                ConfigFileSpecified = true;
                _configFile = value;
            }
        }

        [XmlIgnore]
        public bool ConfigFileSpecified { get; set; }

    }
}
