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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18521""}]")]
    public class FileRepositoryProtocolWebDAV20
    {

        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18521")]
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
        public bool SecureSpecified { get; set; }

        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18521")]
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
        public bool NetAddressSpecified { get; set; }

        private bool _extendedFileCaptureSupport;

        [XmlElement(ElementName = "extendedFileCaptureSupport", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18521")]
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
        public bool ExtendedFileCaptureSupportSpecified { get; set; }

    }
}
