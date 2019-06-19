using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseVoiceVPNGetRequest14sp3.
    /// <see cref="EnterpriseVoiceVPNGetRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1515""}]")]
    public class EnterpriseVoiceVPNGetResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1515")]
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

        private BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDefaultSelection _defaultSelection;

        [XmlElement(ElementName = "defaultSelection", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1515")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDefaultSelection DefaultSelection
        {
            get => _defaultSelection;
            set
            {
                DefaultSelectionSpecified = true;
                _defaultSelection = value;
            }
        }

        [XmlIgnore]
        public bool DefaultSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNNonMatchingE164NumberSelection _e164Selection;

        [XmlElement(ElementName = "e164Selection", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1515")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNNonMatchingE164NumberSelection E164Selection
        {
            get => _e164Selection;
            set
            {
                E164SelectionSpecified = true;
                _e164Selection = value;
            }
        }

        [XmlIgnore]
        public bool E164SelectionSpecified { get; set; }

        private bool _usePhoneContext;

        [XmlElement(ElementName = "usePhoneContext", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1515")]
        public bool UsePhoneContext
        {
            get => _usePhoneContext;
            set
            {
                UsePhoneContextSpecified = true;
                _usePhoneContext = value;
            }
        }

        [XmlIgnore]
        public bool UsePhoneContextSpecified { get; set; }

    }
}
