using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Primary user information.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3494""}]")]
    public class PrimaryUserInfo
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3494")]
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

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3494")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3494")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private string _userFirstName;

        [XmlElement(ElementName = "userFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3494")]
        [MinLength(1)]
        [MaxLength(30)]
        public string UserFirstName
        {
            get => _userFirstName;
            set
            {
                UserFirstNameSpecified = true;
                _userFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool UserFirstNameSpecified { get; set; }

        private string _userLastName;

        [XmlElement(ElementName = "userLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3494")]
        [MinLength(1)]
        [MaxLength(30)]
        public string UserLastName
        {
            get => _userLastName;
            set
            {
                UserLastNameSpecified = true;
                _userLastName = value;
            }
        }

        [XmlIgnore]
        protected bool UserLastNameSpecified { get; set; }

        private string _userPhoneNumber;

        [XmlElement(ElementName = "userPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3494")]
        [MinLength(1)]
        [MaxLength(23)]
        public string UserPhoneNumber
        {
            get => _userPhoneNumber;
            set
            {
                UserPhoneNumberSpecified = true;
                _userPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool UserPhoneNumberSpecified { get; set; }

        private string _userExtension;

        [XmlElement(ElementName = "userExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3494")]
        [MinLength(2)]
        [MaxLength(20)]
        public string UserExtension
        {
            get => _userExtension;
            set
            {
                UserExtensionSpecified = true;
                _userExtension = value;
            }
        }

        [XmlIgnore]
        protected bool UserExtensionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EndpointType21sp1 _endPointType;

        [XmlElement(ElementName = "endPointType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3494")]
        public BroadWorksConnector.Ocip.Models.EndpointType21sp1 EndPointType
        {
            get => _endPointType;
            set
            {
                EndPointTypeSpecified = true;
                _endPointType = value;
            }
        }

        [XmlIgnore]
        protected bool EndPointTypeSpecified { get; set; }

    }
}
