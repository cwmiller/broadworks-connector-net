using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds automatic callback release cause to the releaseCause attribute.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6e1812074dca6af91b3958d73ab352fc:46""}]")]
    public class SystemAutomaticCallbackAddReleaseCauseListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected List<BroadWorksConnector.Ocip.Models.AutomaticCallbackReleaseCause> _releaseCause = new List<BroadWorksConnector.Ocip.Models.AutomaticCallbackReleaseCause>();

        [XmlElement(ElementName = "releaseCause", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6e1812074dca6af91b3958d73ab352fc:46")]
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
