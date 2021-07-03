using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a user of a file repository in the system.
    /// The response is either a SystemFileRepositoryDeviceUserGetResponse or an ErrorResponse.
    /// <see cref="SystemFileRepositoryDeviceUserGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10450""}]")]
    public class SystemFileRepositoryDeviceUserGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _fileRepositoryName;

        [XmlElement(ElementName = "fileRepositoryName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10450")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10450")]
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

    }
}
