using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDirectedCallPickupWithBargeInGetRequest14sp7.
    /// <see cref="UserDirectedCallPickupWithBargeInGetRequest14sp7"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""629ec0086c245a4408ed537aa86aab18:59""}]")]
    public class UserDirectedCallPickupWithBargeInGetResponse14sp7 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableBargeInWarningTone;

        [XmlElement(ElementName = "enableBargeInWarningTone", IsNullable = false, Namespace = "")]
        [Group(@"629ec0086c245a4408ed537aa86aab18:59")]
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
        [Group(@"629ec0086c245a4408ed537aa86aab18:59")]
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
