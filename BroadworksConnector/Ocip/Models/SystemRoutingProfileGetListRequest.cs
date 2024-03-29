using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system routing profiles.
    /// 
    /// If resellerId is specified, the routing profiles assigned to the given reseller are returned. If reseller administrator sends the request, resellerId is not specified, the administrator’s resellerId is used.
    /// If system or provisioning administrator sends the request, resellerId is not specified, all system routing profiles are returned.
    /// 
    /// The response is either a SystemRoutingProfileGetListResponse or an ErrorResponse.
    /// <see cref="SystemRoutingProfileGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15711""}]")]
    public class SystemRoutingProfileGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemRoutingProfileGetListResponse>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:15711")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

    }
}
