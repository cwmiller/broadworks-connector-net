using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNumberPortabilityQueryStatusGetRequest.
    /// <see cref="SystemNumberPortabilityQueryStatusGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13454""}]")]
    public class SystemNumberPortabilityQueryStatusGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _treatmentFileName;

        [XmlElement(ElementName = "treatmentFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13454")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TreatmentFileName
        {
            get => _treatmentFileName;
            set
            {
                TreatmentFileNameSpecified = true;
                _treatmentFileName = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentFileNameSpecified { get; set; }

    }
}
