using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// UserGetLoginInfoRequest22V4 is used to access login information for a user
    /// either by a userId, dn or lineport.
    /// The phone number may be any DN associated with a user.
    /// The lineport may be any lineport associated with a user.
    /// 
    /// The response is a UserGetLoginInfoResponse22V4 or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS and Amplify data mode.
    /// loginRole
    /// <see cref="UserGetLoginInfoRequest22V4"/>
    /// <see cref="UserGetLoginInfoResponse22V4"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:592"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:593"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:594""}]}]}]")]
    public class UserGetLoginInfoRequest22V4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:594")]
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

        private BroadWorksConnector.Ocip.Models.LoginRole _loginRole;

        [XmlElement(ElementName = "loginRole", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:594")]
        public BroadWorksConnector.Ocip.Models.LoginRole LoginRole
        {
            get => _loginRole;
            set
            {
                LoginRoleSpecified = true;
                _loginRole = value;
            }
        }

        [XmlIgnore]
        protected bool LoginRoleSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:593")]
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
        [Group(@"6b27fcc79475236456fc113a42b75543:593")]
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
