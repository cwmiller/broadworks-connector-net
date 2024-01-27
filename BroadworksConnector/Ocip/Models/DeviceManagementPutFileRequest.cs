using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Informs BroadWorks that a file was uploaded to the repository. The response is always a SuccessResponse.
    /// <see cref="SuccessResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef3c4f453d01f7ce750331de83ebc765:219""}]")]
    public class DeviceManagementPutFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceAccessURI;

        [XmlElement(ElementName = "deviceAccessURI", IsNullable = false, Namespace = "")]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:219")]
        [MinLength(1)]
        [MaxLength(256)]
        public string DeviceAccessURI
        {
            get => _deviceAccessURI;
            set
            {
                DeviceAccessURISpecified = true;
                _deviceAccessURI = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAccessURISpecified { get; set; }

        protected string _ipAddress;

        [XmlElement(ElementName = "ipAddress", IsNullable = false, Namespace = "")]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:219")]
        [MinLength(1)]
        [MaxLength(80)]
        public string IpAddress
        {
            get => _ipAddress;
            set
            {
                IpAddressSpecified = true;
                _ipAddress = value;
            }
        }

        [XmlIgnore]
        protected bool IpAddressSpecified { get; set; }

    }
}
