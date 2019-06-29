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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1444""}]")]
    public class EnterpriseVoiceVPNGetPolicyListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _locationList;

        [XmlElement(ElementName = "locationList", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1444")]
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
