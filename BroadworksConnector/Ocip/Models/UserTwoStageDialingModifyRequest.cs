using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Two Stage Dialing.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""103e8fba76512e5a1abfb373758f36e2:163""}]")]
    public class UserTwoStageDialingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"103e8fba76512e5a1abfb373758f36e2:163")]
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
        [Group(@"103e8fba76512e5a1abfb373758f36e2:163")]
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

        protected bool _allowActivationWithUserAddresses;

        [XmlElement(ElementName = "allowActivationWithUserAddresses", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"103e8fba76512e5a1abfb373758f36e2:163")]
        public bool AllowActivationWithUserAddresses
        {
            get => _allowActivationWithUserAddresses;
            set
            {
                AllowActivationWithUserAddressesSpecified = true;
                _allowActivationWithUserAddresses = value;
            }
        }

        [XmlIgnore]
        protected bool AllowActivationWithUserAddressesSpecified { get; set; }

    }
}
