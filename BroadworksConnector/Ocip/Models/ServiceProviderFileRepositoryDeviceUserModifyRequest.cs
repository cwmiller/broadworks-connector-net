using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a service provider file repository user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4323""}]")]
    public class ServiceProviderFileRepositoryDeviceUserModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4323")]
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

        private string _fileRepositoryName;

        [XmlElement(ElementName = "fileRepositoryName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4323")]
        [MinLength(1)]
        [MaxLength(40)]
        public string FileRepositoryName
        {
            get => _fileRepositoryName;
            set
            {
                FileRepositoryNameSpecified = true;
                _fileRepositoryName = value;
            }
        }

        [XmlIgnore]
        protected bool FileRepositoryNameSpecified { get; set; }

        private string _userName;

        [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4323")]
        [MinLength(1)]
        [MaxLength(30)]
        public string UserName
        {
            get => _userName;
            set
            {
                UserNameSpecified = true;
                _userName = value;
            }
        }

        [XmlIgnore]
        protected bool UserNameSpecified { get; set; }

        private string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4323")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Password
        {
            get => _password;
            set
            {
                PasswordSpecified = true;
                _password = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordSpecified { get; set; }

        private bool _allowPut;

        [XmlElement(ElementName = "allowPut", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4323")]
        public bool AllowPut
        {
            get => _allowPut;
            set
            {
                AllowPutSpecified = true;
                _allowPut = value;
            }
        }

        [XmlIgnore]
        protected bool AllowPutSpecified { get; set; }

        private bool _allowDelete;

        [XmlElement(ElementName = "allowDelete", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4323")]
        public bool AllowDelete
        {
            get => _allowDelete;
            set
            {
                AllowDeleteSpecified = true;
                _allowDelete = value;
            }
        }

        [XmlIgnore]
        protected bool AllowDeleteSpecified { get; set; }

        private bool _allowGet;

        [XmlElement(ElementName = "allowGet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4323")]
        public bool AllowGet
        {
            get => _allowGet;
            set
            {
                AllowGetSpecified = true;
                _allowGet = value;
            }
        }

        [XmlIgnore]
        protected bool AllowGetSpecified { get; set; }

    }
}
