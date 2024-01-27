using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the collaborate bridged assigned to the user. The user can only be assigned to one collaborate bridge at any given time.
    /// The response is either UserCollaborateBridgeGetResponse or ErrorResponse.
    /// 
    /// Replaced by: UserCollaborateBridgeGetRequest20sp1
    /// <see cref="UserCollaborateBridgeGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserCollaborateBridgeGetRequest20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:42478""}]")]
    public class UserCollaborateBridgeGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCollaborateBridgeGetResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42478")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

    }
}
