using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of service providers that have a given Office Zone assigned.  The response is either a SystemOfficeZoneGetAssignedServiceProviderListResponse or ErrorResponse.
    /// <see cref="SystemOfficeZoneGetAssignedServiceProviderListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12805""}]")]
    public class SystemOfficeZoneGetAssignedServiceProviderListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _officeZoneName;

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12805")]
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
        public bool OfficeZoneNameSpecified { get; set; }

    }
}
