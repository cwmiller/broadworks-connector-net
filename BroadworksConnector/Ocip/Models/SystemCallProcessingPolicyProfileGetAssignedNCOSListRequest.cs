using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of NCOSs that have a given CallP Policy Profile assigned.
    /// The response is either a SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse or
    /// ErrorResponse.
    /// <see cref="SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:3519""}]")]
    public class SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:3519")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ProfileName
        {
            get => _profileName;
            set
            {
                ProfileNameSpecified = true;
                _profileName = value;
            }
        }

        [XmlIgnore]
        public bool ProfileNameSpecified { get; set; }

    }
}
