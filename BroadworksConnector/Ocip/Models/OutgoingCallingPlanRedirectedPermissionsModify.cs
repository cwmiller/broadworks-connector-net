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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:2123""}]")]
    public class OutgoingCallingPlanRedirectedPermissionsModify
    {

        private bool _outsideGroup;

        [XmlElement(ElementName = "outsideGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2123")]
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
