using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNumberActivationGetRequest.
    /// Contains the system number activation setting.
    /// <see cref="SystemNumberActivationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26297""}]")]
    public class SystemNumberActivationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useNumberActivation;

        [XmlElement(ElementName = "useNumberActivation", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26297")]
        public bool UseNumberActivation
        {
            get => _useNumberActivation;
            set
            {
                UseNumberActivationSpecified = true;
                _useNumberActivation = value;
            }
        }

        [XmlIgnore]
        public bool UseNumberActivationSpecified { get; set; }

    }
}
