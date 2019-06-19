using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointGetAnnouncementRequest20.
    /// <see cref="GroupRoutePointGetAnnouncementRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:365""}]")]
    public class GroupRoutePointGetAnnouncementResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead20 _mediaOnHoldSource;

        [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:365")]
        public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead20 MediaOnHoldSource
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
