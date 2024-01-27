using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14472""}]")]
    public class SystemPerformanceMeasurementReportingAddFileServerRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _repositoryUrl;

        [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14472")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RepositoryUrl
        {
            get => _repositoryUrl;
            set
            {
                RepositoryUrlSpecified = true;
                _repositoryUrl = value;
            }
        }

        [XmlIgnore]
        protected bool RepositoryUrlSpecified { get; set; }

        protected string _ftpUserId;

        [XmlElement(ElementName = "ftpUserId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14472")]
        [MinLength(1)]
        [MaxLength(30)]
        public string FtpUserId
        {
            get => _ftpUserId;
            set
            {
                FtpUserIdSpecified = true;
                _ftpUserId = value;
            }
        }

        [XmlIgnore]
        protected bool FtpUserIdSpecified { get; set; }

        protected string _ftpUserPassword;

        [XmlElement(ElementName = "ftpUserPassword", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14472")]
        [MinLength(1)]
        [MaxLength(40)]
        public string FtpUserPassword
        {
            get => _ftpUserPassword;
            set
            {
                FtpUserPasswordSpecified = true;
                _ftpUserPassword = value;
            }
        }

        [XmlIgnore]
        protected bool FtpUserPasswordSpecified { get; set; }

        protected bool _passiveFTP;

        [XmlElement(ElementName = "passiveFTP", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14472")]
        public bool PassiveFTP
        {
            get => _passiveFTP;
            set
            {
                PassiveFTPSpecified = true;
                _passiveFTP = value;
            }
        }

        [XmlIgnore]
        protected bool PassiveFTPSpecified { get; set; }

    }
}
