using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Associate/Disassociate an access device instance to the user's Shared Call Appearance.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// useHotline
    /// hotlineContact
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""524e0d071a229a44af2f953d6b50db35:184""}]")]
    public class UserSharedCallAppearanceModifyEndpointRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"524e0d071a229a44af2f953d6b50db35:184")]
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
        [Group(@"524e0d071a229a44af2f953d6b50db35:184")]
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

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"524e0d071a229a44af2f953d6b50db35:184")]
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
        [Optional]
        [Group(@"524e0d071a229a44af2f953d6b50db35:184")]
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
        [Optional]
        [Group(@"524e0d071a229a44af2f953d6b50db35:184")]
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

        private bool _useHotline;

        [XmlElement(ElementName = "useHotline", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"524e0d071a229a44af2f953d6b50db35:184")]
        public bool UseHotline
        {
            get => _useHotline;
            set
            {
                UseHotlineSpecified = true;
                _useHotline = value;
            }
        }

        [XmlIgnore]
        protected bool UseHotlineSpecified { get; set; }

        private string _hotlineContact;

        [XmlElement(ElementName = "hotlineContact", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"524e0d071a229a44af2f953d6b50db35:184")]
        [MinLength(1)]
        [MaxLength(161)]
        public string HotlineContact
        {
            get => _hotlineContact;
            set
            {
                HotlineContactSpecified = true;
                _hotlineContact = value;
            }
        }

        [XmlIgnore]
        protected bool HotlineContactSpecified { get; set; }

    }
}
