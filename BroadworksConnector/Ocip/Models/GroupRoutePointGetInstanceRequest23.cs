using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Route Point instance.
    /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
    /// The Following elements are only used in AS data mode and ignored in XS data mode:
    /// - sendCallAdmissionNotification, use value ‘false’ in XS data mode.
    /// - callAdmissionTimerSeconds, use value ‘3’ in XS data mode.
    /// <see cref="GroupRoutePointGetInstanceResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:606""}]")]
    public class GroupRoutePointGetInstanceRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupRoutePointGetInstanceResponse19sp1>
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:606")]
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
