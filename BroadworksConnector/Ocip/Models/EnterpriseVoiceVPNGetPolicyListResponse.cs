using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseVoiceVPNGetListResponse.
    /// Returns a 4 column table with column headings:
    /// "Location Code", "Min Extension Length", "Max Extension Length", "Location Selection".
    /// <see cref="EnterpriseVoiceVPNGetListResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1105""}]")]
    public class EnterpriseVoiceVPNGetPolicyListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _locationList;

        [XmlElement(ElementName = "locationList", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1105")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LocationList
        {
            get => _locationList;
            set
            {
                LocationListSpecified = true;
                _locationList = value;
            }
        }

        [XmlIgnore]
        protected bool LocationListSpecified { get; set; }

    }
}
