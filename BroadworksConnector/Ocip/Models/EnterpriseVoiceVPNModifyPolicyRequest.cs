using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the enterprise level data associated with a Voice VPN location code.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1534"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1542""}]}]")]
    public class EnterpriseVoiceVPNModifyPolicyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1534")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _locationDialingCode;

        [XmlElement(ElementName = "locationDialingCode", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1534")]
        [MinLength(1)]
        [MaxLength(22)]
        public string LocationDialingCode
        {
            get => _locationDialingCode;
            set
            {
                LocationDialingCodeSpecified = true;
                _locationDialingCode = value;
            }
        }

        [XmlIgnore]
        public bool LocationDialingCodeSpecified { get; set; }

        private int _minExtensionLength;

        [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1534")]
        [MinInclusive(0)]
        [MaxInclusive(100)]
        public int MinExtensionLength
        {
            get => _minExtensionLength;
            set
            {
                MinExtensionLengthSpecified = true;
                _minExtensionLength = value;
            }
        }

        [XmlIgnore]
        public bool MinExtensionLengthSpecified { get; set; }

        private int _maxExtensionLength;

        [XmlElement(ElementName = "maxExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1534")]
        [MinInclusive(0)]
        [MaxInclusive(100)]
        public int MaxExtensionLength
        {
            get => _maxExtensionLength;
            set
            {
                MaxExtensionLengthSpecified = true;
                _maxExtensionLength = value;
            }
        }

        [XmlIgnore]
        public bool MaxExtensionLengthSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1534")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }

        private string _routeGroupId;

        [XmlElement(ElementName = "routeGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1534")]
        [MinLength(1)]
        [MaxLength(30)]
        public string RouteGroupId
        {
            get => _routeGroupId;
            set
            {
                RouteGroupIdSpecified = true;
                _routeGroupId = value;
            }
        }

        [XmlIgnore]
        public bool RouteGroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection _policySelection;

        [XmlElement(ElementName = "policySelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1534")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection PolicySelection
        {
            get => _policySelection;
            set
            {
                PolicySelectionSpecified = true;
                _policySelection = value;
            }
        }

        [XmlIgnore]
        public bool PolicySelectionSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation> _digitManipulation = new List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation>();

        [XmlElement(ElementName = "digitManipulation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1542")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation> DigitManipulation
        {
            get => _digitManipulation;
            set
            {
                DigitManipulationSpecified = true;
                _digitManipulation = value;
            }
        }

        [XmlIgnore]
        public bool DigitManipulationSpecified { get; set; }

        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1542")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TreatmentId
        {
            get => _treatmentId;
            set
            {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        public bool TreatmentIdSpecified { get; set; }

    }
}
