using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBusyLampFieldGetRequest.
    /// <see cref="SystemBusyLampFieldGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:20574""}]")]
    public class SystemBusyLampFieldGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _displayLocalUserIdentityLastNameFirst;

        [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:20574")]
        public bool DisplayLocalUserIdentityLastNameFirst
        {
            get => _displayLocalUserIdentityLastNameFirst;
            set
            {
                DisplayLocalUserIdentityLastNameFirstSpecified = true;
                _displayLocalUserIdentityLastNameFirst = value;
            }
        }

        [XmlIgnore]
        protected bool DisplayLocalUserIdentityLastNameFirstSpecified { get; set; }

    }
}
