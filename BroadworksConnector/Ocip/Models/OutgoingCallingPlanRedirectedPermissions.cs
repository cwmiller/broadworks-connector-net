using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan being forwarded/transferred permissions.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:2112""}]")]
    public class OutgoingCallingPlanRedirectedPermissions
    {

        protected bool _outsideGroup;

        [XmlElement(ElementName = "outsideGroup", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:2112")]
        public bool OutsideGroup
        {
            get => _outsideGroup;
            set
            {
                OutsideGroupSpecified = true;
                _outsideGroup = value;
            }
        }

        [XmlIgnore]
        protected bool OutsideGroupSpecified { get; set; }

    }
}
