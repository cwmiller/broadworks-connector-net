using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an existing Office Zone.
    /// The response is either a SystemOfficeZoneGetResponse or an ErrorResponse.
    /// <see cref="SystemOfficeZoneGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13960""}]")]
    public class SystemOfficeZoneGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _officeZoneName;

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13960")]
        [MinLength(1)]
        [MaxLength(40)]
        public string OfficeZoneName
        {
            get => _officeZoneName;
            set
            {
                OfficeZoneNameSpecified = true;
                _officeZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool OfficeZoneNameSpecified { get; set; }

    }
}
