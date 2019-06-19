using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDirectedCallPickupWithBargeInGetRequest.
    /// <see cref="UserDirectedCallPickupWithBargeInGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7144""}]")]
    public class UserDirectedCallPickupWithBargeInGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableBargeInWarningTone;

        [XmlElement(ElementName = "enableBargeInWarningTone", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7144")]
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
        public bool EnableBargeInWarningToneSpecified { get; set; }

    }
}
