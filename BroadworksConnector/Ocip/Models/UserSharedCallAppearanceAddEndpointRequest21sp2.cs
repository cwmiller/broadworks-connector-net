using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Associate an access device instance to the user's Shared Call Appearance.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserSharedCallAppearanceAddEndpointRequest21sp2.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserSharedCallAppearanceAddEndpointRequest21sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:14317""}]")]
    public class UserSharedCallAppearanceAddEndpointRequest21sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14317")]
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

        private BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityEndpointAdd _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14317")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityEndpointAdd AccessDeviceEndpoint
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

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14317")]
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

        private bool _allowOrigination;

        [XmlElement(ElementName = "allowOrigination", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14317")]
        public bool AllowOrigination
        {
            get => _allowOrigination;
            set
            {
                AllowOriginationSpecified = true;
                _allowOrigination = value;
            }
        }

        [XmlIgnore]
        protected bool AllowOriginationSpecified { get; set; }

        private bool _allowTermination;

        [XmlElement(ElementName = "allowTermination", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14317")]
        public bool AllowTermination
        {
            get => _allowTermination;
            set
            {
                AllowTerminationSpecified = true;
                _allowTermination = value;
            }
        }

        [XmlIgnore]
        protected bool AllowTerminationSpecified { get; set; }

        private bool _allowVideo;

        [XmlElement(ElementName = "allowVideo", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14317")]
        public bool AllowVideo
        {
            get => _allowVideo;
            set
            {
                AllowVideoSpecified = true;
                _allowVideo = value;
            }
        }

        [XmlIgnore]
        protected bool AllowVideoSpecified { get; set; }

    }
}
