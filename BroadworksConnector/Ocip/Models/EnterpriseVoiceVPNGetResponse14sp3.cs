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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1176""}]")]
    public class EnterpriseVoiceVPNGetResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1176")]
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

        protected BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDefaultSelection _defaultSelection;

        [XmlElement(ElementName = "defaultSelection", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1176")]
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
        protected bool DefaultSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNNonMatchingE164NumberSelection _e164Selection;

        [XmlElement(ElementName = "e164Selection", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1176")]
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
        protected bool E164SelectionSpecified { get; set; }

        protected bool _usePhoneContext;

        [XmlElement(ElementName = "usePhoneContext", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1176")]
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
        protected bool UsePhoneContextSpecified { get; set; }

    }
}
