using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a file repository user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10484""}]")]
    public class SystemFileRepositoryDeviceUserModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _fileRepositoryName;

        [XmlElement(ElementName = "fileRepositoryName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10484")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10484")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10484")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10484")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10484")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10484")]
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
