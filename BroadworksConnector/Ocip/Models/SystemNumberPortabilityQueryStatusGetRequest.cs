using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get information for a system Number Portability Query Status.
    /// The response is either SystemNumberPortabilityQueryStatusGetResponse or ErrorResponse.
    /// <see cref="SystemNumberPortabilityQueryStatusGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13269""}]")]
    public class SystemNumberPortabilityQueryStatusGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemNumberPortabilityQueryStatusGetResponse>
    {

        private string _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13269")]
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
        protected bool StatusSpecified { get; set; }

    }
}
