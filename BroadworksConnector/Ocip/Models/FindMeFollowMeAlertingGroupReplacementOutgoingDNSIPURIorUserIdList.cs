using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of phone numbers/sipuris or user ids that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:518"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:519"",""optional"":true}]}]")]
    public class FindMeFollowMeAlertingGroupReplacementOutgoingDNSIPURIorUserIdList
    {

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:519")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:519")]
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
