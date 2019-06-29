using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Deletes automatic callback release causes from the release cause attribute.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e8188f390ad4fcfad616cb409dd0e896:62""}]")]
    public class SystemAutomaticCallbackDeleteReleaseCauseListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<BroadWorksConnector.Ocip.Models.AutomaticCallbackReleaseCause> _releaseCause = new List<BroadWorksConnector.Ocip.Models.AutomaticCallbackReleaseCause>();

        [XmlElement(ElementName = "releaseCause", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e8188f390ad4fcfad616cb409dd0e896:62")]
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
