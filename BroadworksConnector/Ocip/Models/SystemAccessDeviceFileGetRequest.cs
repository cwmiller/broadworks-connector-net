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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20063""}]")]
    public class SystemAccessDeviceFileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAccessDeviceFileGetResponse>
    {

        protected string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20063")]
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

        protected string _fileType;

        [XmlElement(ElementName = "fileType", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:20063")]
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
