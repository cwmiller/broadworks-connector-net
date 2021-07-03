using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a sip device type file.
    /// The response is either SystemSIPDeviceTypeFileGetResponse or ErrorResponse.
    /// Replaced By: SystemSIPDeviceTypeFileGetRequest14sp8
    /// <see cref="SystemSIPDeviceTypeFileGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSIPDeviceTypeFileGetRequest14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:31468""}]")]
    public class SystemSIPDeviceTypeFileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:31468")]
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

        private string _fileType;

        [XmlElement(ElementName = "fileType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:31468")]
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
        protected bool FileTypeSpecified { get; set; }

    }
}
