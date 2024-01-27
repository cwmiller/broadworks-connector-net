using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Directed Call Pickup With Barge In service
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4418""}]")]
    public class ProfileAndServiceDirectedCallPickupWithBargeInInfo
    {

        protected bool _enableBargeInWarningTone;

        [XmlElement(ElementName = "enableBargeInWarningTone", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4418")]
        public bool EnableBargeInWarningTone
        {
            get => _enableBargeInWarningTone;
            set
            {
                EnableBargeInWarningToneSpecified = true;
                _enableBargeInWarningTone = value;
            }
        }

        [XmlIgnore]
        protected bool EnableBargeInWarningToneSpecified { get; set; }

        protected bool _enableAutomaticTargetSelection;

        [XmlElement(ElementName = "enableAutomaticTargetSelection", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4418")]
        public bool EnableAutomaticTargetSelection
        {
            get => _enableAutomaticTargetSelection;
            set
            {
                EnableAutomaticTargetSelectionSpecified = true;
                _enableAutomaticTargetSelection = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutomaticTargetSelectionSpecified { get; set; }

    }
}
