using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a sip device type file.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced By: SystemSIPDeviceTypeFileDeleteRequest14sp8
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSIPDeviceTypeFileDeleteRequest14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5967""}]")]
    public class SystemSIPDeviceTypeFileDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5967")]
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

        private string _fileType;

        [XmlElement(ElementName = "fileType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5967")]
        [MinLength(1)]
        [MaxLength(40)]
        public string FileType
        {
            get => _fileType;
            set
            {
                FileTypeSpecified = true;
                _fileType = value;
            }
        }

        [XmlIgnore]
        public bool FileTypeSpecified { get; set; }

    }
}
