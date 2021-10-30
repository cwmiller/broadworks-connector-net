using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the User Personal Assistant information.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f53ece1c00394ef2d3d76f532f9a9663:340""}]")]
    public class UserPersonalAssistantModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:340")]
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

        private BroadWorksConnector.Ocip.Models.PersonalAssistantPresence _presence;

        [XmlElement(ElementName = "presence", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:340")]
        public BroadWorksConnector.Ocip.Models.PersonalAssistantPresence Presence
        {
            get => _presence;
            set
            {
                PresenceSpecified = true;
                _presence = value;
            }
        }

        [XmlIgnore]
        protected bool PresenceSpecified { get; set; }

        private bool _enableTransferToAttendant;

        [XmlElement(ElementName = "enableTransferToAttendant", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:340")]
        public bool EnableTransferToAttendant
        {
            get => _enableTransferToAttendant;
            set
            {
                EnableTransferToAttendantSpecified = true;
                _enableTransferToAttendant = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTransferToAttendantSpecified { get; set; }

        private string _attendantNumber;

        [XmlElement(ElementName = "attendantNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:340")]
        [MinLength(1)]
        [MaxLength(161)]
        public string AttendantNumber
        {
            get => _attendantNumber;
            set
            {
                AttendantNumberSpecified = true;
                _attendantNumber = value;
            }
        }

        [XmlIgnore]
        protected bool AttendantNumberSpecified { get; set; }

        private bool _enableRingSplash;

        [XmlElement(ElementName = "enableRingSplash", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:340")]
        public bool EnableRingSplash
        {
            get => _enableRingSplash;
            set
            {
                EnableRingSplashSpecified = true;
                _enableRingSplash = value;
            }
        }

        [XmlIgnore]
        protected bool EnableRingSplashSpecified { get; set; }

        private bool _enableExpirationTime;

        [XmlElement(ElementName = "enableExpirationTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:340")]
        public bool EnableExpirationTime
        {
            get => _enableExpirationTime;
            set
            {
                EnableExpirationTimeSpecified = true;
                _enableExpirationTime = value;
            }
        }

        [XmlIgnore]
        protected bool EnableExpirationTimeSpecified { get; set; }

        private string _expirationTime;

        [XmlElement(ElementName = "expirationTime", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:340")]
        public string ExpirationTime
        {
            get => _expirationTime;
            set
            {
                ExpirationTimeSpecified = true;
                _expirationTime = value;
            }
        }

        [XmlIgnore]
        protected bool ExpirationTimeSpecified { get; set; }

        private bool _alertMeFirst;

        [XmlElement(ElementName = "alertMeFirst", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:340")]
        public bool AlertMeFirst
        {
            get => _alertMeFirst;
            set
            {
                AlertMeFirstSpecified = true;
                _alertMeFirst = value;
            }
        }

        [XmlIgnore]
        protected bool AlertMeFirstSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.PersonalAssistantAlertMeFirstNumberOfRings _alertMeFirstNumberOfRings;

        [XmlElement(ElementName = "alertMeFirstNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f53ece1c00394ef2d3d76f532f9a9663:340")]
        public BroadWorksConnector.Ocip.Models.PersonalAssistantAlertMeFirstNumberOfRings AlertMeFirstNumberOfRings
        {
            get => _alertMeFirstNumberOfRings;
            set
            {
                AlertMeFirstNumberOfRingsSpecified = true;
                _alertMeFirstNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool AlertMeFirstNumberOfRingsSpecified { get; set; }

    }
}
