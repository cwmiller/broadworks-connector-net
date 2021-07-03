using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to apply an extended file capture value to all the profile instances associated to a sip device type file.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16781""}]")]
    public class SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16781")]
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

        private string _fileFormat;

        [XmlElement(ElementName = "fileFormat", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16781")]
        [MinLength(1)]
        [MaxLength(128)]
        public string FileFormat
        {
            get => _fileFormat;
            set
            {
                FileFormatSpecified = true;
                _fileFormat = value;
            }
        }

        [XmlIgnore]
        protected bool FileFormatSpecified { get; set; }

        private bool _extendedCaptureOnUploadFromDevice;

        [XmlElement(ElementName = "extendedCaptureOnUploadFromDevice", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16781")]
        public bool ExtendedCaptureOnUploadFromDevice
        {
            get => _extendedCaptureOnUploadFromDevice;
            set
            {
                ExtendedCaptureOnUploadFromDeviceSpecified = true;
                _extendedCaptureOnUploadFromDevice = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedCaptureOnUploadFromDeviceSpecified { get; set; }

    }
}
