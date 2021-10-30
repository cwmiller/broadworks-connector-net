using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Communication Barring Criteria.
    /// The response is either a SystemCommunicationBarringCriteriaGetResponse
    /// or an ErrorResponse.
    /// Replaced by: SystemCommunicationBarringCriteriaGetRequest17
    /// <see cref="SystemCommunicationBarringCriteriaGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCommunicationBarringCriteriaGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:24987""}]")]
    public class SystemCommunicationBarringCriteriaGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCommunicationBarringCriteriaGetResponse>
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24987")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

    }
}
