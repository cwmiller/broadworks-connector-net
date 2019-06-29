using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a NS Treatment mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17806""}]")]
    public class SystemTreatmentMappingNetworkServerTreatmentDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _nsTreatment;

        [XmlElement(ElementName = "nsTreatment", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17806")]
        [MinLength(1)]
        [MaxLength(8)]
        public string NsTreatment
        {
            get => _nsTreatment;
            set
            {
                NsTreatmentSpecified = true;
                _nsTreatment = value;
            }
        }

        [XmlIgnore]
        protected bool NsTreatmentSpecified { get; set; }

    }
}
