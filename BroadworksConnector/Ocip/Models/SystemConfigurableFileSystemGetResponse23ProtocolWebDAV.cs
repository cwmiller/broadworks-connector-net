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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7891""}]")]
    public class SystemConfigurableFileSystemGetResponse23ProtocolWebDAV
    {

        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7891")]
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

        private string _userName;

        [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7891")]
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
        protected bool UserNameSpecified { get; set; }

        private string _fileServerFQDN;

        [XmlElement(ElementName = "fileServerFQDN", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7891")]
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
        protected bool FileServerFQDNSpecified { get; set; }

    }
}
