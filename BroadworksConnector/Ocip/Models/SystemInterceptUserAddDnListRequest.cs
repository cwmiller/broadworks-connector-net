using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add an Intercept User number(s) to the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2a762bb9361e88044885b796c1d6b979:143""}]")]
    public class SystemInterceptUserAddDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> _interceptDNList = new List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry>();

        [XmlElement(ElementName = "interceptDNList", IsNullable = false, Namespace = "")]
        [Group(@"2a762bb9361e88044885b796c1d6b979:143")]
        public List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> InterceptDNList
        {
            get => _interceptDNList;
            set
            {
                InterceptDNListSpecified = true;
                _interceptDNList = value;
            }
        }

        [XmlIgnore]
        protected bool InterceptDNListSpecified { get; set; }

    }
}
