using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a device profile file.
    /// The response is either SystemAccessDeviceFileGetResponse or ErrorResponse.
    /// Replaced By: SystemAccessDeviceFileGetRequest14sp8
    /// <see cref="SystemAccessDeviceFileGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAccessDeviceFileGetRequest14sp8"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:19405""}]")]
    public class SystemAccessDeviceFileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19405")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool DeviceNameSpecified { get; set; }

        private string _fileType;

        [XmlElement(ElementName = "fileType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19405")]
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
