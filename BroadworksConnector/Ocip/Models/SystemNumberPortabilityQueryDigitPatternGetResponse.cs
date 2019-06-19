using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNumberPortabilityQueryDigitPatternGetRequest.
    /// <see cref="SystemNumberPortabilityQueryDigitPatternGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11997""}]")]
    public class SystemNumberPortabilityQueryDigitPatternGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11997")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }

    }
}
