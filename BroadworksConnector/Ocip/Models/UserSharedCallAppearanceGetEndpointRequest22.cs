using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's Shared Call Appearance endpoint setting.
    /// The response is either a UserSharedCallAppearanceGetEndpointResponse22 or an ErrorResponse.
    /// <see cref="UserSharedCallAppearanceGetEndpointResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""524e0d071a229a44af2f953d6b50db35:90""}]")]
    public class UserSharedCallAppearanceGetEndpointRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserSharedCallAppearanceGetEndpointResponse22>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"524e0d071a229a44af2f953d6b50db35:90")]
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

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointKey _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"524e0d071a229a44af2f953d6b50db35:90")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointKey AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceEndpointSpecified { get; set; }

    }
}
