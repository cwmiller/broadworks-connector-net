using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns a zone calling physical location for a given zone. The response is either a SystemZoneCallingZonePhysicalLocationGetResponse or an ErrorResponse.
    /// <see cref="SystemZoneCallingZonePhysicalLocationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19613""}]")]
    public class SystemZoneCallingZonePhysicalLocationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemZoneCallingZonePhysicalLocationGetResponse>
    {

        private string _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19613")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ZoneName
        {
            get => _zoneName;
            set
            {
                ZoneNameSpecified = true;
                _zoneName = value;
            }
        }

        [XmlIgnore]
        protected bool ZoneNameSpecified { get; set; }

    }
}
