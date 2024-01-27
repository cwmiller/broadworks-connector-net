using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Attributes of the WebDav protocol when the file repository interface is using WebDav.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:20180""}]")]
    public class FileRepositoryProtocolWebDAV20
    {

        protected bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:20180")]
        public bool Secure
        {
            get => _secure;
            set
            {
                SecureSpecified = true;
                _secure = value;
            }
        }

        [XmlIgnore]
        protected bool SecureSpecified { get; set; }

        protected string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:20180")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        protected bool NetAddressSpecified { get; set; }

        protected bool _extendedFileCaptureSupport;

        [XmlElement(ElementName = "extendedFileCaptureSupport", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:20180")]
        public bool ExtendedFileCaptureSupport
        {
            get => _extendedFileCaptureSupport;
            set
            {
                ExtendedFileCaptureSupportSpecified = true;
                _extendedFileCaptureSupport = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedFileCaptureSupportSpecified { get; set; }

    }
}
