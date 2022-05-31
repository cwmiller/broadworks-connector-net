using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEmergencyZonesGetRequest.
    /// <see cref="GroupEmergencyZonesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e71c2205fb31894f87810b330a85ede2:137""}]")]
    public class GroupEmergencyZonesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"e71c2205fb31894f87810b330a85ede2:137")]
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

        protected BroadWorksConnector.Ocip.Models.EmergencyZonesProhibition _emergencyZonesProhibition;

        [XmlElement(ElementName = "emergencyZonesProhibition", IsNullable = false, Namespace = "")]
        [Group(@"e71c2205fb31894f87810b330a85ede2:137")]
        public BroadWorksConnector.Ocip.Models.EmergencyZonesProhibition EmergencyZonesProhibition
        {
            get => _emergencyZonesProhibition;
            set
            {
                EmergencyZonesProhibitionSpecified = true;
                _emergencyZonesProhibition = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyZonesProhibitionSpecified { get; set; }

        protected bool _sendEmergencyCallNotifyEmail;

        [XmlElement(ElementName = "sendEmergencyCallNotifyEmail", IsNullable = false, Namespace = "")]
        [Group(@"e71c2205fb31894f87810b330a85ede2:137")]
        public bool SendEmergencyCallNotifyEmail
        {
            get => _sendEmergencyCallNotifyEmail;
            set
            {
                SendEmergencyCallNotifyEmailSpecified = true;
                _sendEmergencyCallNotifyEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SendEmergencyCallNotifyEmailSpecified { get; set; }

        protected string _emergencyCallNotifyEmailAddress;

        [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e71c2205fb31894f87810b330a85ede2:137")]
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

    }
}
