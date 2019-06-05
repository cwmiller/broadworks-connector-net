using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class FileRepositoryProtocolWebDAV20
    {
        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
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
