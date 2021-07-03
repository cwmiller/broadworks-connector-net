using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the settings for a user's specified mobile identity.
    /// The response is either a UserBroadWorksMobilityMobileIdentityGetResponse22 or an ErrorResponse.
    /// Replaced by UserBroadWorksMobilityMobileIdentityGetRequest22V2.
    /// <see cref="UserBroadWorksMobilityMobileIdentityGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserBroadWorksMobilityMobileIdentityGetRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:40030""}]")]
    public class UserBroadWorksMobilityMobileIdentityGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40030")]
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

        private string _mobileNumber;

        [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40030")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MobileNumber
        {
            get => _mobileNumber;
            set
            {
                MobileNumberSpecified = true;
                _mobileNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNumberSpecified { get; set; }

    }
}
