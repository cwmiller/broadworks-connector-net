using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemInterceptUserGetDnListRequest.
    /// The Intercept User DN List.
    /// <see cref="SystemInterceptUserGetDnListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2a762bb9361e88044885b796c1d6b979:190""}]")]
    public class SystemInterceptUserGetDnListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> _interceptUserList = new List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry>();

        [XmlElement(ElementName = "interceptUserList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2a762bb9361e88044885b796c1d6b979:190")]
        public List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> InterceptUserList
        {
            get => _interceptUserList;
            set
            {
                InterceptUserListSpecified = true;
                _interceptUserList = value;
            }
        }

        [XmlIgnore]
        protected bool InterceptUserListSpecified { get; set; }

    }
}
