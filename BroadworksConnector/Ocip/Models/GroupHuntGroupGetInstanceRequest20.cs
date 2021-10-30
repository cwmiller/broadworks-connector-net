using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Hunt Group instance.
    /// The response is either GroupHuntGroupGetInstanceResponse20 or ErrorResponse.
    /// <see cref="GroupHuntGroupGetInstanceResponse20"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc829065f9d696d3ca7084121d57f8c0:443""}]")]
    public class GroupHuntGroupGetInstanceRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupHuntGroupGetInstanceResponse20>
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:443")]
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
