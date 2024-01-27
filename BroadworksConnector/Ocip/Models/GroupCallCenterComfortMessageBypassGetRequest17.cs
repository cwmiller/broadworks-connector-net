using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a call center's comfort message bypass settings.
    /// The response is either a GroupCallCenterComfortMessageBypassGetResponse17 or an ErrorResponse.
    /// 
    /// Replaced by: GroupCallCenterComfortMessageBypassGetRequest20
    /// <see cref="GroupCallCenterComfortMessageBypassGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallCenterComfortMessageBypassGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:4825""}]")]
    public class GroupCallCenterComfortMessageBypassGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterComfortMessageBypassGetResponse17>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:4825")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

    }
}
