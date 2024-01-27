using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of feature access codes for a user.
    /// The response is either a UserFeatureAccessCodeGetListResponse20 or an ErrorResponse.
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording Start".
    /// Replaced by: UserFeatureAccessCodeGetListRequest21 in AS data mode
    /// <see cref="UserFeatureAccessCodeGetListResponse20"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserFeatureAccessCodeGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:43569""}]")]
    public class UserFeatureAccessCodeGetListRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserFeatureAccessCodeGetListResponse20>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:43569")]
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
