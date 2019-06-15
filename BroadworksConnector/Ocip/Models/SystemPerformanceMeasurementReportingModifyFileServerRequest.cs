using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a performance measurements reporting ftp server.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPerformanceMeasurementReportingModifyFileServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _ftpHostNetAddress;

        [XmlElement(ElementName = "ftpHostNetAddress", IsNullable = false, Namespace = "")]
        public string FtpHostNetAddress {
            get => _ftpHostNetAddress;
            set {
                FtpHostNetAddressSpecified = true;
                _ftpHostNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool FtpHostNetAddressSpecified { get; set; }
        
        private bool _passiveFTP;

        [XmlElement(ElementName = "passiveFTP", IsNullable = false, Namespace = "")]
        public bool PassiveFTP {
            get => _passiveFTP;
            set {
                PassiveFTPSpecified = true;
                _passiveFTP = value;
            }
        }

        [XmlIgnore]
        public bool PassiveFTPSpecified { get; set; }
        
    }
}
