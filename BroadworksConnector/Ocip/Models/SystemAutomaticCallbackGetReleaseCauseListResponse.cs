using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAutomaticCallbackGetReleaseCauseListRequest.
    /// <see cref="SystemAutomaticCallbackGetReleaseCauseListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6e1812074dca6af91b3958d73ab352fc:91""}]")]
    public class SystemAutomaticCallbackGetReleaseCauseListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.AutomaticCallbackReleaseCause> _releaseCause = new List<BroadWorksConnector.Ocip.Models.AutomaticCallbackReleaseCause>();

        [XmlElement(ElementName = "releaseCause", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:91")]
        public List<BroadWorksConnector.Ocip.Models.AutomaticCallbackReleaseCause> ReleaseCause
        {
            get => _releaseCause;
            set
            {
                ReleaseCauseSpecified = true;
                _releaseCause = value;
            }
        }

        [XmlIgnore]
        protected bool ReleaseCauseSpecified { get; set; }

    }
}
