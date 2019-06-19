using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBusyLampFieldGetRequest18.
    /// 
    /// The following elements are only used in AS data mode:
    /// forceUseOfTCP
    /// <see cref="SystemBusyLampFieldGetRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4faeca417998d23ce2ff6b0b43212aa6:61""}]")]
    public class SystemBusyLampFieldGetResponse18 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _displayLocalUserIdentityLastNameFirst;

        [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false, Namespace = "")]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:61")]
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
        public bool DisplayLocalUserIdentityLastNameFirstSpecified { get; set; }

        private bool _forceUseOfTCP;

        [XmlElement(ElementName = "forceUseOfTCP", IsNullable = false, Namespace = "")]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:61")]
        public bool ForceUseOfTCP
        {
            get => _forceUseOfTCP;
            set
            {
                ForceUseOfTCPSpecified = true;
                _forceUseOfTCP = value;
            }
        }

        [XmlIgnore]
        public bool ForceUseOfTCPSpecified { get; set; }

    }
}
