using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemInCallServiceActivationGetRequest17.
    /// <see cref="SystemInCallServiceActivationGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ece0b65e69189d3e8b8deee895f0a7ff:107""}]")]
    public class SystemInCallServiceActivationGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _defaultFlashActivationDigits;

        [XmlElement(ElementName = "defaultFlashActivationDigits", IsNullable = false, Namespace = "")]
        [Group(@"ece0b65e69189d3e8b8deee895f0a7ff:107")]
        [MinLength(1)]
        [MaxLength(8)]
        public string DefaultFlashActivationDigits
        {
            get => _defaultFlashActivationDigits;
            set
            {
                DefaultFlashActivationDigitsSpecified = true;
                _defaultFlashActivationDigits = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultFlashActivationDigitsSpecified { get; set; }

        protected string _defaultCallTransferActivationDigits;

        [XmlElement(ElementName = "defaultCallTransferActivationDigits", IsNullable = false, Namespace = "")]
        [Group(@"ece0b65e69189d3e8b8deee895f0a7ff:107")]
        [MinLength(1)]
        [MaxLength(8)]
        public string DefaultCallTransferActivationDigits
        {
            get => _defaultCallTransferActivationDigits;
            set
            {
                DefaultCallTransferActivationDigitsSpecified = true;
                _defaultCallTransferActivationDigits = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultCallTransferActivationDigitsSpecified { get; set; }

    }
}
