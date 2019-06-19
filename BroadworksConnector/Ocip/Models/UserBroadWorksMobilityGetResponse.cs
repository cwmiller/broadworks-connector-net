using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a UserBroadWorksMobilityGetRequest.
    /// <see cref="UserBroadWorksMobilityGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a8b2edcd7d6936a8b76653949ae59623:186""}]")]
    public class UserBroadWorksMobilityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
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
        public bool IsActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing _phonesToRing;

        [XmlElement(ElementName = "phonesToRing", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        public BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing PhonesToRing
        {
            get => _phonesToRing;
            set
            {
                PhonesToRingSpecified = true;
                _phonesToRing = value;
            }
        }

        [XmlIgnore]
        public bool PhonesToRingSpecified { get; set; }

        private string _mobilePhoneNumber;

        [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MobilePhoneNumber
        {
            get => _mobilePhoneNumber;
            set
            {
                MobilePhoneNumberSpecified = true;
                _mobilePhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool MobilePhoneNumberSpecified { get; set; }

        private bool _alertClickToDialCalls;

        [XmlElement(ElementName = "alertClickToDialCalls", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        public bool AlertClickToDialCalls
        {
            get => _alertClickToDialCalls;
            set
            {
                AlertClickToDialCallsSpecified = true;
                _alertClickToDialCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertClickToDialCallsSpecified { get; set; }

        private bool _alertGroupPagingCalls;

        [XmlElement(ElementName = "alertGroupPagingCalls", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        public bool AlertGroupPagingCalls
        {
            get => _alertGroupPagingCalls;
            set
            {
                AlertGroupPagingCallsSpecified = true;
                _alertGroupPagingCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertGroupPagingCallsSpecified { get; set; }

        private bool _enableDiversionInhibitor;

        [XmlElement(ElementName = "enableDiversionInhibitor", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        public bool EnableDiversionInhibitor
        {
            get => _enableDiversionInhibitor;
            set
            {
                EnableDiversionInhibitorSpecified = true;
                _enableDiversionInhibitor = value;
            }
        }

        [XmlIgnore]
        public bool EnableDiversionInhibitorSpecified { get; set; }

        private bool _requireAnswerConfirmation;

        [XmlElement(ElementName = "requireAnswerConfirmation", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        public bool RequireAnswerConfirmation
        {
            get => _requireAnswerConfirmation;
            set
            {
                RequireAnswerConfirmationSpecified = true;
                _requireAnswerConfirmation = value;
            }
        }

        [XmlIgnore]
        public bool RequireAnswerConfirmationSpecified { get; set; }

        private bool _broadworksCallControl;

        [XmlElement(ElementName = "broadworksCallControl", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        public bool BroadworksCallControl
        {
            get => _broadworksCallControl;
            set
            {
                BroadworksCallControlSpecified = true;
                _broadworksCallControl = value;
            }
        }

        [XmlIgnore]
        public bool BroadworksCallControlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BroadWorksMobilityUserSettingLevel _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        public BroadWorksConnector.Ocip.Models.BroadWorksMobilityUserSettingLevel UseSettingLevel
        {
            get => _useSettingLevel;
            set
            {
                UseSettingLevelSpecified = true;
                _useSettingLevel = value;
            }
        }

        [XmlIgnore]
        public bool UseSettingLevelSpecified { get; set; }

        private bool _denyCallOriginations;

        [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        public bool DenyCallOriginations
        {
            get => _denyCallOriginations;
            set
            {
                DenyCallOriginationsSpecified = true;
                _denyCallOriginations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallOriginationsSpecified { get; set; }

        private bool _denyCallTerminations;

        [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:186")]
        public bool DenyCallTerminations
        {
            get => _denyCallTerminations;
            set
            {
                DenyCallTerminationsSpecified = true;
                _denyCallTerminations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallTerminationsSpecified { get; set; }

    }
}
