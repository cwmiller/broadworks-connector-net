using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the settings for a user's specified mobile identity.
    /// The response is either a UserBroadWorksMobilityMobileIdentityGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserBroadWorksMobilityMobileIdentityGetRequest21sp1.
    /// <see cref="UserBroadWorksMobilityMobileIdentityGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserBroadWorksMobilityMobileIdentityGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:40091""}]")]
    public class UserBroadWorksMobilityMobileIdentityGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40091")]
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
        public bool UserIdSpecified { get; set; }

        private string _mobileNumber;

        [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40091")]
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
        public bool MobileNumberSpecified { get; set; }

    }
}
