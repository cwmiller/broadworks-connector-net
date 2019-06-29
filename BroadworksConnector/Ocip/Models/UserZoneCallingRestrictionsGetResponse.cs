using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets the home zone for a user
    /// Response to a UserZoneCallingRestrictionsGetRequest
    /// <see cref="UserZoneCallingRestrictionsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da5cd0d79ddb505982e08d164e405660:116""}]")]
    public class UserZoneCallingRestrictionsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _homeZoneName;

        [XmlElement(ElementName = "homeZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da5cd0d79ddb505982e08d164e405660:116")]
        [MinLength(1)]
        [MaxLength(80)]
        public string HomeZoneName
        {
            get => _homeZoneName;
            set
            {
                HomeZoneNameSpecified = true;
                _homeZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZoneNameSpecified { get; set; }

    }
}
