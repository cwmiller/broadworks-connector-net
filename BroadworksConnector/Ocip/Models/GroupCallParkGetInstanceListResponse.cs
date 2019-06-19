using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallParkGetInstanceListRequest.
    /// <see cref="GroupCallParkGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7a925e891158dfa3cb1319e045608894:302""}]")]
    public class GroupCallParkGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _name = new List<string>();

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:302")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }

    }
}
