using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of applicationIds that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4417""}]")]
    public class ReplacementOCICallControlApplicationIdList
    {

        private List<string> _applicationId = new List<string>();

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4417")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> ApplicationId
        {
            get => _applicationId;
            set
            {
                ApplicationIdSpecified = true;
                _applicationId = value;
            }
        }

        [XmlIgnore]
        public bool ApplicationIdSpecified { get; set; }

    }
}
