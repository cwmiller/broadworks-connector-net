using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Do Not Disturb.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// The following element is only used in AS data mode and ignored in XS data mode: isDoNotDisturbSync
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f424ffe4eea042849235863d758363ec:76""}]")]
    public class UserDoNotDisturbModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"f424ffe4eea042849235863d758363ec:76")]
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

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f424ffe4eea042849235863d758363ec:76")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected bool _ringSplash;

        [XmlElement(ElementName = "ringSplash", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f424ffe4eea042849235863d758363ec:76")]
        public bool RingSplash
        {
            get => _ringSplash;
            set
            {
                RingSplashSpecified = true;
                _ringSplash = value;
            }
        }

        [XmlIgnore]
        protected bool RingSplashSpecified { get; set; }

        protected bool _isDoNotDisturbSync;

        [XmlElement(ElementName = "isDoNotDisturbSync", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f424ffe4eea042849235863d758363ec:76")]
        public bool IsDoNotDisturbSync
        {
            get => _isDoNotDisturbSync;
            set
            {
                IsDoNotDisturbSyncSpecified = true;
                _isDoNotDisturbSync = value;
            }
        }

        [XmlIgnore]
        protected bool IsDoNotDisturbSyncSpecified { get; set; }

    }
}
