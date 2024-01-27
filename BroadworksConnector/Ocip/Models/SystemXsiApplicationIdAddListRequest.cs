using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add the system Xsi application Id entries.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19630""}]")]
    public class SystemXsiApplicationIdAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.XsiApplicationIdEntry> _xsiApplicationIdEntry = new List<BroadWorksConnector.Ocip.Models.XsiApplicationIdEntry>();

        [XmlElement(ElementName = "xsiApplicationIdEntry", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19630")]
        public List<BroadWorksConnector.Ocip.Models.XsiApplicationIdEntry> XsiApplicationIdEntry
        {
            get => _xsiApplicationIdEntry;
            set
            {
                XsiApplicationIdEntrySpecified = true;
                _xsiApplicationIdEntry = value;
            }
        }

        [XmlIgnore]
        protected bool XsiApplicationIdEntrySpecified { get; set; }

    }
}
