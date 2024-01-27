using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the service provider or enterprise level data associated with Emergency
    /// Call Notification.  The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4153""}]")]
    public class ServiceProviderEmergencyCallNotificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4153")]
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

        protected bool _sendEmergencyCallNotificationEmail;

        [XmlElement(ElementName = "sendEmergencyCallNotificationEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4153")]
        public bool SendEmergencyCallNotificationEmail
        {
            get => _sendEmergencyCallNotificationEmail;
            set
            {
                SendEmergencyCallNotificationEmailSpecified = true;
                _sendEmergencyCallNotificationEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SendEmergencyCallNotificationEmailSpecified { get; set; }

        protected string _emergencyCallNotifyEmailAddress;

        [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4153")]
        [MinLength(1)]
        [MaxLength(80)]
        public string EmergencyCallNotifyEmailAddress
        {
            get => _emergencyCallNotifyEmailAddress;
            set
            {
                EmergencyCallNotifyEmailAddressSpecified = true;
                _emergencyCallNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyCallNotifyEmailAddressSpecified { get; set; }

        protected bool _allowGroupOverride;

        [XmlElement(ElementName = "allowGroupOverride", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4153")]
        public bool AllowGroupOverride
        {
            get => _allowGroupOverride;
            set
            {
                AllowGroupOverrideSpecified = true;
                _allowGroupOverride = value;
            }
        }

        [XmlIgnore]
        protected bool AllowGroupOverrideSpecified { get; set; }

    }
}
