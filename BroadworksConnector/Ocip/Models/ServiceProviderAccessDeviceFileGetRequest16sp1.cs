using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a service provider device profile file.
    /// The response is either ServiceProviderAccessDeviceFileGetResponse16sp1 or ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderAccessDeviceFileGetRequest20
    /// <see cref="ServiceProviderAccessDeviceFileGetResponse16sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderAccessDeviceFileGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:17139""}]")]
    public class ServiceProviderAccessDeviceFileGetRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderAccessDeviceFileGetResponse16sp1>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:17139")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:17139")]
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

        protected string _fileFormat;

        [XmlElement(ElementName = "fileFormat", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:17139")]
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

    }
}
