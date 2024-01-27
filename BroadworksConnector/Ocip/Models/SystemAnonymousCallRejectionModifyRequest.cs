using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a system Anonymous Call Rejection parameter.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""17d2110a0df023b843fdbd156e17bec8:77""}]")]
    public class SystemAnonymousCallRejectionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _paiRequired;

        [XmlElement(ElementName = "paiRequired", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"17d2110a0df023b843fdbd156e17bec8:77")]
        public bool PaiRequired
        {
            get => _paiRequired;
            set
            {
                PaiRequiredSpecified = true;
                _paiRequired = value;
            }
        }

        [XmlIgnore]
        protected bool PaiRequiredSpecified { get; set; }

        protected bool _screenOnlyLocalCalls;

        [XmlElement(ElementName = "screenOnlyLocalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"17d2110a0df023b843fdbd156e17bec8:77")]
        public bool ScreenOnlyLocalCalls
        {
            get => _screenOnlyLocalCalls;
            set
            {
                ScreenOnlyLocalCallsSpecified = true;
                _screenOnlyLocalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ScreenOnlyLocalCallsSpecified { get; set; }

    }
}
