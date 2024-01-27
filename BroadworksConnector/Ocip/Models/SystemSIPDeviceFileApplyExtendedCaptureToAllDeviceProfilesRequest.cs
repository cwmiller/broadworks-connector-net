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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17001""}]")]
    public class SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17001")]
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

        protected string _fileFormat;

        [XmlElement(ElementName = "fileFormat", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17001")]
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

        protected bool _extendedCaptureOnUploadFromDevice;

        [XmlElement(ElementName = "extendedCaptureOnUploadFromDevice", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17001")]
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
