using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's legacy automatic callback line type attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6bf3c0ead6c4d948122ea83af7fc6e34:118""}]")]
    public class SystemLegacyAutomaticCallbackModifyLineTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineType _lineType;

        [XmlElement(ElementName = "lineType", IsNullable = false, Namespace = "")]
        [Group(@"6bf3c0ead6c4d948122ea83af7fc6e34:118")]
        public BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineType LineType
        {
            get => _lineType;
            set
            {
                LineTypeSpecified = true;
                _lineType = value;
            }
        }

        [XmlIgnore]
        public bool LineTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction _matchAction;

        [XmlElement(ElementName = "matchAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bf3c0ead6c4d948122ea83af7fc6e34:118")]
        public BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction MatchAction
        {
            get => _matchAction;
            set
            {
                MatchActionSpecified = true;
                _matchAction = value;
            }
        }

        [XmlIgnore]
        public bool MatchActionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction _noMatchAction;

        [XmlElement(ElementName = "noMatchAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bf3c0ead6c4d948122ea83af7fc6e34:118")]
        public BroadWorksConnector.Ocip.Models.LegacyAutomaticCallbackLineMatchAction NoMatchAction
        {
            get => _noMatchAction;
            set
            {
                NoMatchActionSpecified = true;
                _noMatchAction = value;
            }
        }

        [XmlIgnore]
        public bool NoMatchActionSpecified { get; set; }

    }
}
