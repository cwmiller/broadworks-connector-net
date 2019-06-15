using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a performance measurements reporting ftp server.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPerformanceMeasurementReportingAddFileServerRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _repositoryUrl;

        [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
        public string RepositoryUrl {
            get => _repositoryUrl;
            set {
                RepositoryUrlSpecified = true;
                _repositoryUrl = value;
            }
        }

        [XmlIgnore]
        public bool RepositoryUrlSpecified { get; set; }
        
        private string _ftpUserId;

        [XmlElement(ElementName = "ftpUserId", IsNullable = false, Namespace = "")]
        public string FtpUserId {
            get => _ftpUserId;
            set {
                FtpUserIdSpecified = true;
                _ftpUserId = value;
            }
        }

        [XmlIgnore]
        public bool FtpUserIdSpecified { get; set; }
        
        private string _ftpUserPassword;

        [XmlElement(ElementName = "ftpUserPassword", IsNullable = false, Namespace = "")]
        public string FtpUserPassword {
            get => _ftpUserPassword;
            set {
                FtpUserPasswordSpecified = true;
                _ftpUserPassword = value;
            }
        }

        [XmlIgnore]
        public bool FtpUserPasswordSpecified { get; set; }
        
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
