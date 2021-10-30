using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// UserGetLoginInfoRequest21sp1 is used to access login information for a user
    /// either by a userId, dn or lineport.
    /// The phone number may be any DN associated with a user.
    /// The lineport may be any lineport associated with a user.
    /// 
    /// The response is a UserGetLoginInfoResponse21sp1 or an ErrorResponse
    /// 
    /// Replaced by UserGetLoginInfoRequest22V2.
    /// <see cref="UserGetLoginInfoRequest21sp1"/>
    /// <see cref="UserGetLoginInfoResponse21sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserGetLoginInfoRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:43095"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:43096""}]}]")]
    public class UserGetLoginInfoRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserGetLoginInfoResponse21sp1>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43096")]
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

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43096")]
        [MinLength(1)]
        [MaxLength(23)]
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

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43096")]
        [MinLength(1)]
        [MaxLength(161)]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortSpecified { get; set; }

    }
}
