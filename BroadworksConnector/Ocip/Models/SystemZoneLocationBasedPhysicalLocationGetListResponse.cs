using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemZoneLocationBasedPhysicalLocationGetListRequest.
    /// <see cref="SystemZoneLocationBasedPhysicalLocationGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19756""}]")]
    public class SystemZoneLocationBasedPhysicalLocationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _physicalLocation = new List<string>();

        [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19756")]
        [MinLength(1)]
        [MaxLength(1024)]
        public List<string> PhysicalLocation
        {
            get => _physicalLocation;
            set
            {
                PhysicalLocationSpecified = true;
                _physicalLocation = value;
            }
        }

        [XmlIgnore]
        protected bool PhysicalLocationSpecified { get; set; }

    }
}
