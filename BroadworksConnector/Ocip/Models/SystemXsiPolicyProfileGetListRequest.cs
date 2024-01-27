using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Xsi policy profile list.
    /// The response is either SystemXsiPolicyProfileGetListResponse or ErrorResponse.
    /// <see cref="SystemXsiPolicyProfileGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19827""}]")]
    public class SystemXsiPolicyProfileGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemXsiPolicyProfileGetListResponse>
    {

        protected BroadWorksConnector.Ocip.Models.XsiPolicyProfileLevel _xsiPolicyProfileLevel;

        [XmlElement(ElementName = "xsiPolicyProfileLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19827")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileLevel XsiPolicyProfileLevel
        {
            get => _xsiPolicyProfileLevel;
            set
            {
                XsiPolicyProfileLevelSpecified = true;
                _xsiPolicyProfileLevel = value;
            }
        }

        [XmlIgnore]
        protected bool XsiPolicyProfileLevelSpecified { get; set; }

    }
}
