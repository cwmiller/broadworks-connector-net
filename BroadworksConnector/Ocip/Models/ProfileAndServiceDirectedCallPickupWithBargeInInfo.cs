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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4225""}]")]
    public class ProfileAndServiceDirectedCallPickupWithBargeInInfo
    {

        private bool _enableBargeInWarningTone;

        [XmlElement(ElementName = "enableBargeInWarningTone", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4225")]
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

        private bool _enableAutomaticTargetSelection;

        [XmlElement(ElementName = "enableAutomaticTargetSelection", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4225")]
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
