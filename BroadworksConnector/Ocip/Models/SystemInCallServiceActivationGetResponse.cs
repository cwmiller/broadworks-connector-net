using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemInCallServiceActivationGetRequest.
    /// Replaced by: SystemInCallServiceActivationGetResponse17
    /// <see cref="SystemInCallServiceActivationGetRequest"/>
    /// <see cref="SystemInCallServiceActivationGetResponse17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15564""}]")]
    public class SystemInCallServiceActivationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _defaultActivationDigits;

        [XmlElement(ElementName = "defaultActivationDigits", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15564")]
        [MinLength(1)]
        [MaxLength(8)]
        public string DefaultActivationDigits
        {
            get => _defaultActivationDigits;
            set
            {
                DefaultActivationDigitsSpecified = true;
                _defaultActivationDigits = value;
            }
        }

        [XmlIgnore]
        public bool DefaultActivationDigitsSpecified { get; set; }

    }
}
