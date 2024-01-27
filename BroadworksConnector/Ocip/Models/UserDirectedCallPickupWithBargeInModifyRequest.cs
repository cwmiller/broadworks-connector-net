using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Directed Call Pickup With Barge In.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""629ec0086c245a4408ed537aa86aab18:76""}]")]
    public class UserDirectedCallPickupWithBargeInModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"629ec0086c245a4408ed537aa86aab18:76")]
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

        protected bool _enableBargeInWarningTone;

        [XmlElement(ElementName = "enableBargeInWarningTone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"629ec0086c245a4408ed537aa86aab18:76")]
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
        [Optional]
        [Group(@"629ec0086c245a4408ed537aa86aab18:76")]
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
