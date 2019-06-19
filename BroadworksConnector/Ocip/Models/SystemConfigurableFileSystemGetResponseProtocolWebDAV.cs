using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1563""}]")]
    public class SystemConfigurableFileSystemGetResponseProtocolWebDAV
    {

        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1563")]
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

        private string _userName;

        [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1563")]
        [MinLength(1)]
        [MaxLength(40)]
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
        public bool UserNameSpecified { get; set; }

        private string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1563")]
        [MinLength(1)]
        [MaxLength(40)]
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
        public bool PasswordSpecified { get; set; }

        private string _fileServerFQDN;

        [XmlElement(ElementName = "fileServerFQDN", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1563")]
        [MinLength(1)]
        [MaxLength(80)]
        public string FileServerFQDN
        {
            get => _fileServerFQDN;
            set
            {
                FileServerFQDNSpecified = true;
                _fileServerFQDN = value;
            }
        }

        [XmlIgnore]
        public bool FileServerFQDNSpecified { get; set; }

    }
}
