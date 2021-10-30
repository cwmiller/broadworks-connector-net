using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of users for a file repository in the system.
    /// The response is either a SystemFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
    /// <see cref="SystemFileRepositoryDeviceUserGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10418""}]")]
    public class SystemFileRepositoryDeviceUserGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemFileRepositoryDeviceUserGetListResponse>
    {

        private string _fileRepositoryName;

        [XmlElement(ElementName = "fileRepositoryName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10418")]
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

    }
}
