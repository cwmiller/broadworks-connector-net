using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a route point DNIS announcement settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:819""}]")]
    public class GroupRoutePointModifyDNISAnnouncementRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:819")]
        public BroadWorksConnector.Ocip.Models.DNISKey DnisKey
        {
            get => _dnisKey;
            set
            {
                DnisKeySpecified = true;
                _dnisKey = value;
            }
        }

        [XmlIgnore]
        public bool DnisKeySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify20 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:819")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify20 MediaOnHoldSource
        {
            get => _mediaOnHoldSource;
            set
            {
                MediaOnHoldSourceSpecified = true;
                _mediaOnHoldSource = value;
            }
        }

        [XmlIgnore]
        public bool MediaOnHoldSourceSpecified { get; set; }

    }
}
